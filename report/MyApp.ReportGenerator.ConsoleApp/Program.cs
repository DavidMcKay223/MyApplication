using MyApp.ReportGenerator;
using MyApp.ReportGenerator.Services;
using System;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace MyApp.ReportGenerator.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Build configuration
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory()) // Set the base path for the configuration file
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true) // Add appsettings.json
                .Build();

            // Read settings from configuration
            var projectPath = configuration["Settings:ProjectPath"];
            var outputPath = configuration["Settings:OutputPath"];

            // Optionally, allow command-line arguments to override configuration settings
            if (args.Length > 0 && !string.IsNullOrWhiteSpace(args[0]))
            {
                projectPath = args[0];
            }

            if (args.Length > 1 && !string.IsNullOrWhiteSpace(args[1]))
            {
                outputPath = args[1];
            }

            // Validate paths
            if (string.IsNullOrWhiteSpace(projectPath) || string.IsNullOrWhiteSpace(outputPath))
            {
                Console.WriteLine("Error: ProjectPath and OutputPath must be specified in the configuration or as command-line arguments.");
                return;
            }

            var codeAnalysisService = new CodeAnalysisService();
            var reportGenerationService = new ReportGenerationService();
            var diagramGenerationService = new DiagramGenerationService();

            try
            {
                Console.WriteLine("Analyzing source files...");
                var classes = codeAnalysisService.AnalyzeSourceFiles(projectPath);

                Console.WriteLine("Generating documentation...");
                reportGenerationService.GenerateReports(classes, outputPath);

                Console.WriteLine("Generating diagrams...");
                diagramGenerationService.GenerateDependencyGraph(classes, outputPath);
                diagramGenerationService.GenerateProjectDependencyGraph(classes, outputPath);

                Console.WriteLine("Documentation and diagrams generated successfully!");
                Console.WriteLine($"Output located at: {Path.GetFullPath(outputPath)}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
