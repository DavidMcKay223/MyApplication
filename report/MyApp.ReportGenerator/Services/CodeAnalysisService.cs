using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using MyApp.ReportGenerator.Models;
using MyApp.ReportGenerator.Utilities;

namespace MyApp.ReportGenerator.Services
{
    public class CodeAnalysisService
    {
        /// <summary>
        /// Analyzes C# source files and extracts class information.
        /// </summary>
        public List<ClassInfo> AnalyzeSourceFiles(string solutionPath)
        {
            var classes = new List<ClassInfo>();
            var csFiles = Directory.GetFiles(solutionPath, "*.cs", SearchOption.AllDirectories);

            foreach (var file in csFiles)
            {
                var code = FileHelper.ReadFileContent(file);
                var syntaxTree = CSharpSyntaxTree.ParseText(code);
                var root = syntaxTree.GetCompilationUnitRoot();

                var classDeclarations = root.DescendantNodes().OfType<ClassDeclarationSyntax>();

                foreach (var classDecl in classDeclarations)
                {
                    var classSpan = classDecl.FullSpan;
                    var classCode = code.Substring(classSpan.Start, classSpan.Length);
                    classCode = FileHelper.NormalizeCode(classCode);
                    classCode = FileHelper.FixIndentation(classCode);

                    var relativeFilePath = Path.GetRelativePath(solutionPath, file);

                    // Get project name and subfolder path
                    var (projectName, subfolderPath) = GetProjectAndSubfolderFromPath(relativeFilePath);

                    var classInfo = new ClassInfo
                    {
                        Name = classDecl.Identifier.Text,
                        Namespace = GetNamespace(classDecl),
                        FilePath = file,
                        RelativePath = relativeFilePath,
                        CodeSnippet = classCode,
                        ProjectName = projectName,
                        SubfolderPath = subfolderPath
                    };

                    classInfo.BaseTypes.AddRange(GetBaseTypes(classDecl));
                    classInfo.Properties.AddRange(GetProperties(classDecl));
                    classInfo.Methods.AddRange(GetMethods(classDecl));
                    classInfo.Dependencies.AddRange(GetDependencies(classDecl));

                    classes.Add(classInfo);
                }
            }

            return classes;
        }

        private (string ProjectName, string SubfolderPath) GetProjectAndSubfolderFromPath(string relativeFilePath)
        {
            var parts = relativeFilePath.Split(Path.DirectorySeparatorChar, StringSplitOptions.RemoveEmptyEntries);

            // The first part is assumed to be the project folder
            string projectName = parts.Length > 0 ? parts[0] : "Unknown";

            // Combine the subfolder parts
            string subfolderPath = string.Empty;
            if (parts.Length > 2)
            {
                subfolderPath = Path.Combine(parts.Skip(1).Take(parts.Length - 2).ToArray());
            }

            return (projectName, subfolderPath);
        }

        private List<string> GetDependencies(ClassDeclarationSyntax classDecl)
        {
            var dependencies = new List<string>();

            // Analyze property types
            var propertyTypes = classDecl.Members.OfType<PropertyDeclarationSyntax>()
                .Select(p => p.Type.ToString());

            dependencies.AddRange(propertyTypes);

            // Analyze method parameter and return types
            var methodDeclarations = classDecl.Members.OfType<MethodDeclarationSyntax>();
            foreach (var method in methodDeclarations)
            {
                // Return type
                dependencies.Add(method.ReturnType.ToString());

                // Parameter types
                var parameterTypes = method.ParameterList.Parameters
                    .Select(p => p.Type?.ToString())
                    .Where(t => !string.IsNullOrEmpty(t));

                dependencies.AddRange(parameterTypes);
            }

            // Filter out system types and primitives
            var systemTypes = new HashSet<string> { "int", "string", "bool", "double", "float", "decimal", "object", "void", "char", "byte", "short", "long", "ulong", "ushort", "uint", "sbyte", "dynamic" };
            dependencies = dependencies
                .Where(dep => !systemTypes.Contains(dep) && !string.IsNullOrWhiteSpace(dep))
                .Distinct()
                .ToList();

            return dependencies;
        }

        private string GetNamespace(SyntaxNode classDecl)
        {
            var namespaceNode = classDecl.Ancestors()
                                         .OfType<NamespaceDeclarationSyntax>()
                                         .FirstOrDefault();

            return namespaceNode != null ? namespaceNode.Name.ToString() : "(Global Namespace)";
        }

        private List<string> GetBaseTypes(ClassDeclarationSyntax classDecl)
        {
            var baseTypes = new List<string>();

            if (classDecl.BaseList != null)
            {
                foreach (var baseType in classDecl.BaseList.Types)
                {
                    baseTypes.Add(baseType.Type.ToString());
                }
            }

            return baseTypes;
        }

        private List<PropertyInfo> GetProperties(ClassDeclarationSyntax classDecl)
        {
            var properties = new List<PropertyInfo>();

            foreach (var prop in classDecl.Members.OfType<PropertyDeclarationSyntax>())
            {
                var propType = prop.Type.ToString();
                var propName = prop.Identifier.Text;

                // Get the full code of the property
                var propCode = prop.ToFullString();
                propCode = FileHelper.NormalizeCode(propCode);
                propCode = FileHelper.FixIndentation(propCode);

                properties.Add(new PropertyInfo
                {
                    Name = propName,
                    Type = propType,
                    CodeSnippet = propCode
                });
            }

            return properties;
        }

        private List<MethodInfo> GetMethods(ClassDeclarationSyntax classDecl)
        {
            var methods = new List<MethodInfo>();

            var methodDeclarations = classDecl.Members.OfType<MethodDeclarationSyntax>();

            foreach (var methodDecl in methodDeclarations)
            {
                var methodInfo = new MethodInfo
                {
                    Name = methodDecl.Identifier.Text,
                    ReturnType = methodDecl.ReturnType.ToString(),
                    AccessModifier = GetAccessModifier(methodDecl.Modifiers),
                    IsStatic = methodDecl.Modifiers.Any(SyntaxKind.StaticKeyword),
                    Parameters = GetMethodParameters(methodDecl)
                };

                // Get the full code of the method
                var methodCode = methodDecl.ToFullString();
                methodCode = FileHelper.NormalizeCode(methodCode);
                methodCode = FileHelper.FixIndentation(methodCode);

                methodInfo.CodeSnippet = methodCode;

                methods.Add(methodInfo);
            }

            return methods;
        }

        private string GetAccessModifier(SyntaxTokenList modifiers)
        {
            if (modifiers.Any(SyntaxKind.PublicKeyword))
                return "public";
            if (modifiers.Any(SyntaxKind.InternalKeyword))
                return "internal";
            if (modifiers.Any(SyntaxKind.ProtectedKeyword) && modifiers.Any(SyntaxKind.InternalKeyword))
                return "protected internal";
            if (modifiers.Any(SyntaxKind.ProtectedKeyword))
                return "protected";
            if (modifiers.Any(SyntaxKind.PrivateKeyword))
                return "private";

            // Default access modifier
            return "private";
        }

        private List<ParameterInfo> GetMethodParameters(MethodDeclarationSyntax methodDecl)
        {
            var parameters = new List<ParameterInfo>();

            foreach (var parameter in methodDecl.ParameterList.Parameters)
            {
                var paramInfo = new ParameterInfo
                {
                    Name = parameter.Identifier.Text,
                    Type = parameter.Type?.ToString() ?? "var"
                };

                parameters.Add(paramInfo);
            }

            return parameters;
        }
    }
}
