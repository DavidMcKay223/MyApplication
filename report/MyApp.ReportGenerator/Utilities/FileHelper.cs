using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.ReportGenerator.Utilities
{
    public static class FileHelper
    {
        /// <summary>
        /// Reads the content of a file.
        /// </summary>
        public static string ReadFileContent(string filePath)
        {
            return File.ReadAllText(filePath);
        }

        /// <summary>
        /// Normalizes code by replacing tabs with spaces and normalizing line endings.
        /// </summary>
        public static string NormalizeCode(string code)
        {
            // Replace tabs with 4 spaces
            code = code.Replace("\t", "    ");
            // Normalize line endings to '\n'
            code = code.Replace("\r\n", "\n").Replace("\r", "\n");
            return code;
        }

        /// <summary>
        /// Fixes indentation by removing common leading whitespace.
        /// </summary>
        public static string FixIndentation(string code)
        {
            var lines = code.Split('\n');
            // Find the minimum indentation (excluding empty lines)
            int? minIndent = null;
            foreach (var line in lines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;
                var indentLength = line.TakeWhile(char.IsWhiteSpace).Count();
                if (minIndent == null || indentLength < minIndent)
                {
                    minIndent = indentLength;
                }
            }

            // Remove the minimum indentation from each line
            var fixedLines = lines.Select(line =>
            {
                if (string.IsNullOrWhiteSpace(line)) return line.TrimEnd();
                return line.Substring(minIndent.Value).TrimEnd();
            });

            return string.Join("\n", fixedLines);
        }
    }
}
