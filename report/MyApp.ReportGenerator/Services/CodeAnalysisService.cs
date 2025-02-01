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
        /// Analyzes C# source files in the given project path and extracts class information.
        /// </summary>
        /// <param name="projectPath">The root directory of the C# project.</param>
        /// <returns>List of ClassInfo objects representing each class found.</returns>
        public List<ClassInfo> AnalyzeSourceFiles(string projectPath)
        {
            var csFiles = Directory.GetFiles(projectPath, "*.cs", SearchOption.AllDirectories);
            var classes = new List<ClassInfo>();

            foreach (var file in csFiles)
            {
                var code = FileHelper.ReadFileContent(file);
                var syntaxTree = CSharpSyntaxTree.ParseText(code);
                var root = syntaxTree.GetRoot();

                var classDeclarations = root.DescendantNodes().OfType<ClassDeclarationSyntax>();

                foreach (var classDecl in classDeclarations)
                {
                    var classInfo = new ClassInfo
                    {
                        Name = classDecl.Identifier.Text,
                        Namespace = GetNamespace(classDecl),
                        FilePath = file,
                        RelativePath = Path.GetRelativePath(projectPath, file)
                    };

                    classInfo.BaseTypes.AddRange(GetBaseTypes(classDecl));
                    classInfo.Properties.AddRange(GetProperties(classDecl));
                    classInfo.Methods.AddRange(GetMethods(classDecl));

                    classes.Add(classInfo);
                }
            }

            return classes;
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

        private List<string> GetProperties(ClassDeclarationSyntax classDecl)
        {
            var properties = classDecl.Members
                                      .OfType<PropertyDeclarationSyntax>()
                                      .Select(prop => $"{prop.Type.ToString()} {prop.Identifier.Text}")
                                      .ToList();
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
