using MyApp.ReportGenerator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.ReportGenerator.Services
{
    public class ReportGenerationService
    {
        /// <summary>
        /// Generates Markdown reports for the provided classes.
        /// </summary>
        /// <param name="classes">List of ClassInfo objects.</param>
        /// <param name="outputPath">Directory where the reports will be saved.</param>
        public void GenerateReports(List<ClassInfo> classes, string outputPath)
        {
            Directory.CreateDirectory(outputPath);

            foreach (var classInfo in classes)
            {
                var content = GenerateClassMarkdown(classInfo);
                var fileName = $"{classInfo.Namespace}-{classInfo.Name}.md";
                var filePath = Path.Combine(outputPath, fileName);

                File.WriteAllText(filePath, content);
            }

            // Optionally, generate an index or summary README
            GenerateIndexMarkdown(classes, outputPath);
        }

        private string GenerateClassMarkdown(ClassInfo classInfo)
        {
            var sb = new StringBuilder();

            sb.AppendLine($"# {classInfo.Name}");
            sb.AppendLine();
            sb.AppendLine($"**Namespace:** `{classInfo.Namespace}`");
            sb.AppendLine();
            sb.AppendLine($"**File Path:** `{classInfo.RelativePath.Replace("\\", "/")}`");
            sb.AppendLine();

            if (classInfo.BaseTypes.Any())
            {
                sb.AppendLine("## Inherits From");
                sb.AppendLine();
                foreach (var baseType in classInfo.BaseTypes)
                {
                    sb.AppendLine($"- `{baseType}`");
                }
                sb.AppendLine();
            }

            if (classInfo.Properties.Any())
            {
                sb.AppendLine("## Properties");
                sb.AppendLine();
                foreach (var prop in classInfo.Properties)
                {
                    sb.AppendLine($"- `{prop}`");
                }
                sb.AppendLine();
            }

            if (classInfo.Methods.Any())
            {
                sb.AppendLine("## Methods");
                sb.AppendLine();
                foreach (var method in classInfo.Methods)
                {
                    var parameters = string.Join(", ", method.Parameters.Select(p => $"{p.Type} {p.Name}"));
                    sb.AppendLine($"- `{method.AccessModifier}` {(method.IsStatic ? "static " : "")}`{method.ReturnType} {method.Name}({parameters})`");
                }
                sb.AppendLine();
            }

            return sb.ToString();
        }

        private void GenerateIndexMarkdown(List<ClassInfo> classes, string outputPath)
        {
            var sb = new StringBuilder();

            sb.AppendLine("# Project Classes Index");
            sb.AppendLine();

            foreach (var classInfo in classes.OrderBy(c => c.Name))
            {
                var relativePath = $"{classInfo.Namespace}-{classInfo.Name}.md";
                sb.AppendLine($"- [{classInfo.Namespace}.{classInfo.Name}]({relativePath})");
            }

            var filePath = Path.Combine(outputPath, "README.md");
            File.WriteAllText(filePath, sb.ToString());
        }
    }
}
