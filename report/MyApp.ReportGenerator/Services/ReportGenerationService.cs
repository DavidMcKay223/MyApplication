﻿using MyApp.ReportGenerator.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MyApp.ReportGenerator.Services
{
    public class ReportGenerationService
    {
        /// <summary>
        /// Generates Markdown reports for the provided classes, including properties and methods with code snippets, grouped by namespace.
        /// </summary>
        public void GenerateReports(List<ClassInfo> classes, string outputPath)
        {
            Directory.CreateDirectory(outputPath);

            // Group classes by Namespace
            var namespaceGroups = classes.GroupBy(c => c.Namespace);

            foreach (var namespaceGroup in namespaceGroups)
            {
                string content = $"# Namespace: `{namespaceGroup.Key}`\n\n";
                content += GenerateNamespaceContent(namespaceGroup.ToList());

                var fileName = $"{namespaceGroup.Key.Replace('.', '_')}.md";
                var filePath = Path.Combine(outputPath, fileName);

                File.WriteAllText(filePath, content);
            }

            // Generate an index or summary README
            GenerateIndexMarkdown(namespaceGroups, outputPath);
        }

        private string GenerateNamespaceContent(List<ClassInfo> classes)
        {
            var sb = new StringBuilder();

            foreach (var classInfo in classes.OrderBy(c => c.Name))
            {
                sb.AppendLine($"## Class: `{classInfo.Name}`");
                sb.AppendLine();

                sb.AppendLine($"- **File Path:** `{classInfo.RelativePath.Replace("\\", "/")}`");

                if (classInfo.BaseTypes.Any())
                {
                    var inheritsFrom = string.Join(", ", classInfo.BaseTypes.Select(bt => $"`{bt}`"));
                    sb.AppendLine($"- **Inherits From:** {inheritsFrom}");
                }
                else
                {
                    sb.AppendLine($"- **Inherits From:** N/A");
                }

                // Include the full class code (optional)
                sb.AppendLine();
                sb.AppendLine("### Class Code");
                sb.AppendLine();
                sb.AppendLine("```csharp");
                sb.AppendLine(classInfo.CodeSnippet);
                sb.AppendLine("```");

                if (classInfo.Properties.Any())
                {
                    sb.AppendLine();
                    sb.AppendLine("### Properties");
                    sb.AppendLine();

                    // Table Header for Properties
                    sb.AppendLine("| Name | Type |");
                    sb.AppendLine("|------|------|");

                    // Table Rows
                    foreach (var prop in classInfo.Properties)
                    {
                        sb.AppendLine($"| `{prop.Name}` | `{prop.Type}` |");
                    }

                    //// Include code snippets for properties
                    //foreach (var prop in classInfo.Properties)
                    //{
                    //    sb.AppendLine();
                    //    sb.AppendLine($"#### Property: `{prop.Name}`");
                    //    sb.AppendLine();
                    //    sb.AppendLine("```csharp");
                    //    sb.AppendLine(prop.CodeSnippet);
                    //    sb.AppendLine("```");
                    //}
                }

                if (classInfo.Methods.Any())
                {
                    sb.AppendLine();
                    sb.AppendLine("### Methods");
                    sb.AppendLine();

                    // Table Header for Methods
                    sb.AppendLine("| Name | Signature |");
                    sb.AppendLine("|------|-----------|");

                    // Table Rows
                    foreach (var method in classInfo.Methods)
                    {
                        var parameters = method.Parameters.Any()
                            ? string.Join(", ", method.Parameters.Select(p => $"{p.Type} {p.Name}"))
                            : "";
                        var signature = $"{(method.AccessModifier != "private" ? method.AccessModifier + " " : "")}{(method.IsStatic ? "static " : "")}{method.ReturnType} {method.Name}({parameters})";

                        sb.AppendLine($"| `{method.Name}` | `{signature}` |");
                    }

                    // Include code snippets for methods
                    foreach (var method in classInfo.Methods)
                    {
                        sb.AppendLine();
                        sb.AppendLine($"#### Method: `{method.Name}`");
                        sb.AppendLine();
                        sb.AppendLine("```csharp");
                        sb.AppendLine(method.CodeSnippet);
                        sb.AppendLine("```");
                    }
                }

                sb.AppendLine(); // Add an empty line after each class for readability
            }

            return sb.ToString();
        }

        private void GenerateIndexMarkdown(IEnumerable<IGrouping<string, ClassInfo>> namespaceGroups, string outputPath)
        {
            var sb = new StringBuilder();

            // Project Title
            sb.AppendLine("# Project Documentation");
            sb.AppendLine();

            // Project Description
            sb.AppendLine("This documentation provides an overview of the project's classes, organized by namespace.");
            sb.AppendLine();

            // Table of Contents
            sb.AppendLine("## Table of Contents");
            sb.AppendLine();

            foreach (var namespaceGroup in namespaceGroups.OrderBy(g => g.Key))
            {
                var namespaceFileName = $"{namespaceGroup.Key.Replace('.', '_')}.md";

                sb.AppendLine($"- [Namespace: `{namespaceGroup.Key}`]({namespaceFileName})");

                // List classes under the namespace
                foreach (var classInfo in namespaceGroup.OrderBy(c => c.Name))
                {
                    var classAnchor = $"class-{classInfo.Name.ToLower()}";
                    sb.AppendLine($"  - [`{classInfo.Name}`]({namespaceFileName}#{classAnchor})");
                }

                sb.AppendLine();
            }

            // Footer
            sb.AppendLine("---");
            sb.AppendLine("*Generated by MyApp.ReportGenerator*");

            var filePath = Path.Combine(outputPath, "README.md");
            File.WriteAllText(filePath, sb.ToString());
        }
    }
}
