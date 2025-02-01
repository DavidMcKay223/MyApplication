using MyApp.ReportGenerator.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MyApp.ReportGenerator.Services
{
    public class ReportGenerationService
    {
        /// <summary>
        /// Generates Markdown reports for the provided classes, including properties, grouped by namespace.
        /// </summary>
        /// <param name="classes">List of ClassInfo objects.</param>
        /// <param name="outputPath">Directory where the reports will be saved.</param>
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
                        var propertyParts = prop.Split(' ');
                        var propType = propertyParts[0];
                        var propName = propertyParts[1];

                        sb.AppendLine($"| `{propName}` | `{propType}` |");
                    }
                }

                if (classInfo.Methods.Any())
                {
                    sb.AppendLine();
                    sb.AppendLine("### Methods");
                    sb.AppendLine();

                    // Table Header for Methods
                    sb.AppendLine("| Name | Return Type | Access Modifier | Static | Parameters |");
                    sb.AppendLine("|------|-------------|-----------------|--------|------------|");

                    // Table Rows
                    foreach (var method in classInfo.Methods)
                    {
                        var parameters = method.Parameters.Any()
                            ? string.Join(", ", method.Parameters.Select(p => $"`{p.Type} {p.Name}`"))
                            : "None";

                        sb.AppendLine($"| `{method.Name}` | `{method.ReturnType}` | `{method.AccessModifier}` | `{(method.IsStatic ? "Yes" : "No")}` | {parameters} |");
                    }
                }

                sb.AppendLine(); // Add an empty line after each class for readability
            }

            return sb.ToString();
        }

        private void GenerateIndexMarkdown(IEnumerable<IGrouping<string, ClassInfo>> namespaceGroups, string outputPath)
        {
            var sb = new StringBuilder();

            sb.AppendLine("# Project Classes Index");
            sb.AppendLine();

            foreach (var namespaceGroup in namespaceGroups.OrderBy(g => g.Key))
            {
                var namespaceFileName = $"{namespaceGroup.Key.Replace('.', '_')}.md";
                sb.AppendLine($"- [Namespace: `{namespaceGroup.Key}`]({namespaceFileName})");
            }

            var filePath = Path.Combine(outputPath, "README.md");
            File.WriteAllText(filePath, sb.ToString());
        }
    }
}
