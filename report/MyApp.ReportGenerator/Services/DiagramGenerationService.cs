using MyApp.ReportGenerator.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.ReportGenerator.Services
{
    public class DiagramGenerationService
    {
        /// <summary>
        /// Generates dependency diagrams and saves them as images or PDFs.
        /// </summary>
        public void GenerateDependencyGraph(List<ClassInfo> classes, string outputPath)
        {
    // Build DOT graph content with subfolders
    string dotContent = BuildDotContent(classes);

    // Save DOT file
    string dotFilePath = Path.Combine(outputPath, "DependencyGraph.dot");
    File.WriteAllText(dotFilePath, dotContent);

    // Render image
    RenderGraph(dotFilePath, Path.Combine(outputPath, "DependencyGraph.png"), "png");

    // Optionally, render PDF
    // RenderGraph(dotFilePath, Path.Combine(outputPath, "DependencyGraph.pdf"), "pdf");
}

        private string BuildDotContent(List<ClassInfo> classes)
        {
            var sb = new StringBuilder();
            sb.AppendLine("digraph G {");
            sb.AppendLine("    rankdir=LR;"); // Left to right layout
            sb.AppendLine("    node [shape=box];");

            // Group classes by project
            var projects = classes.GroupBy(c => c.ProjectName);

            foreach (var projectGroup in projects)
            {
                var projectName = projectGroup.Key;
                sb.AppendLine($"    subgraph cluster_{SanitizeIdentifier(projectName)} {{");
                sb.AppendLine($"        label = \"{projectName}\";");
                sb.AppendLine($"        style=filled;");
                sb.AppendLine($"        color=lightgrey;");
                sb.AppendLine($"        node [style=filled, color=white];");

                // Group classes by subfolder within the project
                var subfolders = projectGroup.GroupBy(c => c.SubfolderPath);

                foreach (var subfolderGroup in subfolders)
                {
                    var subfolderPath = subfolderGroup.Key;

                    if (!string.IsNullOrEmpty(subfolderPath))
                    {
                        sb.AppendLine($"        subgraph cluster_{SanitizeIdentifier(projectName)}_{SanitizeIdentifier(subfolderPath)} {{");
                        sb.AppendLine($"            label = \"{subfolderPath.Replace(Path.DirectorySeparatorChar, '/')}\";");
                        sb.AppendLine($"            style=filled;");
                        sb.AppendLine($"            color=white;");

                        foreach (var classInfo in subfolderGroup)
                        {
                            sb.AppendLine($"            \"{classInfo.Name}\";");
                        }

                        sb.AppendLine("        }");
                    }
                    else
                    {
                        // Classes in the root of the project
                        foreach (var classInfo in subfolderGroup)
                        {
                            sb.AppendLine($"        \"{classInfo.Name}\";");
                        }
                    }
                }

                sb.AppendLine("    }");
            }

            // Define edges
            foreach (var classInfo in classes)
            {
                // Inheritance
                foreach (var baseType in classInfo.BaseTypes)
                {
                    sb.AppendLine($"    \"{classInfo.Name}\" -> \"{baseType}\" [label=\"inherits\"];");
                }

                // Dependencies
                foreach (var dependency in classInfo.Dependencies)
                {
                    sb.AppendLine($"    \"{classInfo.Name}\" -> \"{dependency}\" [style=\"dotted\", label=\"uses\"];");
                }
            }

            sb.AppendLine("}");
            return sb.ToString();
        }

        private string SanitizeIdentifier(string identifier)
        {
            return identifier.Replace('.', '_')
                             .Replace('-', '_')
                             .Replace(' ', '_')
                             .Replace(Path.DirectorySeparatorChar.ToString(), "_")
                             .Replace(Path.AltDirectorySeparatorChar.ToString(), "_");
        }

        private string BuildProjectLevelDotContent(List<ClassInfo> classes)
        {
            var sb = new StringBuilder();
            sb.AppendLine("digraph G {");
            sb.AppendLine("    rankdir=LR;");
            sb.AppendLine("    node [shape=box];");

            // List of projects
            var projects = classes.Select(c => c.ProjectName).Distinct().ToList();

            // Define nodes for projects with styles
            foreach (var project in projects)
            {
                var color = GetColorForProject(project);
                sb.AppendLine($"    \"{project}\" [style=filled, fillcolor=\"{color}\"];");
            }

            // Determine dependencies between projects
            // (Same as before)

            sb.AppendLine("}");
            return sb.ToString();
        }

        private string GetColorForProject(string projectName)
        {
            return projectName switch
            {
                "Domain" => "#FFA07A",        // Light Salmon
                "Application" => "#98FB98",   // Pale Green
                "Infrastructure" => "#87CEFA",// Light Sky Blue
                "WebApp" => "#DDA0DD",        // Plum
                _ => "#FFFFFF",               // Default to white
            };
        }

        public void GenerateProjectDependencyGraph(List<ClassInfo> classes, string outputPath)
        {
            // Build DOT graph content for projects
            string dotContent = BuildProjectLevelDotContent(classes);

            // Save DOT file
            string dotFilePath = Path.Combine(outputPath, "ProjectDependencyGraph.dot");
            File.WriteAllText(dotFilePath, dotContent);

            // Render image
            RenderGraph(dotFilePath, Path.Combine(outputPath, "ProjectDependencyGraph.png"), "png");

            // Optionally, render PDF
            RenderGraph(dotFilePath, Path.Combine(outputPath, "ProjectDependencyGraph.pdf"), "pdf");
        }


        private void RenderGraph(string dotFilePath, string outputFilePath, string format)
        {
            var processInfo = new ProcessStartInfo
            {
                FileName = "dot",
                Arguments = $"-T{format} \"{dotFilePath}\" -o \"{outputFilePath}\"",
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (var process = new Process { StartInfo = processInfo })
            {
                process.Start();
                string stdout = process.StandardOutput.ReadToEnd();
                string stderr = process.StandardError.ReadToEnd();
                process.WaitForExit();

                if (process.ExitCode != 0)
                {
                    // Handle errors
                    throw new System.Exception($"Error rendering graph: {stderr}");
                }
            }
        }
    }
}
