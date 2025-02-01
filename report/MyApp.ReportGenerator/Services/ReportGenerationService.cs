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
        /// Generates Markdown reports for the provided classes, grouped by namespace.
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
                content += GenerateNamespaceTable(namespaceGroup.ToList());

                var fileName = $"{namespaceGroup.Key.Replace('.', '_')}.md";
                var filePath = Path.Combine(outputPath, fileName);

                File.WriteAllText(filePath, content);
            }

            // Generate an index or summary README
            GenerateIndexMarkdown(namespaceGroups, outputPath);
        }

        private string GenerateNamespaceTable(List<ClassInfo> classes)
        {
            var sb = new StringBuilder();

            // Table Header
            sb.AppendLine("| Class Name | File Path | Inherits From |");
            sb.AppendLine("|------------|-----------|---------------|");

            // Table Rows
            foreach (var classInfo in classes.OrderBy(c => c.Name))
            {
                var inheritsFrom = classInfo.BaseTypes.Any()
                    ? string.Join(", ", classInfo.BaseTypes.Select(bt => $"`{bt}`"))
                    : "N/A";

                var filePath = classInfo.RelativePath.Replace("\\", "/");

                sb.AppendLine($"| `{classInfo.Name}` | `{filePath}` | {inheritsFrom} |");
            }

            sb.AppendLine(); // Add an empty line after the table for Markdown formatting

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
