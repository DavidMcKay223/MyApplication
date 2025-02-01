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
        /// Reads the content of a file, ensuring proper disposal of the stream.
        /// </summary>
        public static string ReadFileContent(string filePath)
        {
            using (var reader = new StreamReader(filePath))
            {
                return reader.ReadToEnd();
            }
        }

        /// <summary>
        /// Combines paths and normalizes directory separator characters.
        /// </summary>
        public static string NormalizePath(params string[] paths)
        {
            var combinedPath = Path.Combine(paths);
            return Path.GetFullPath(new Uri(combinedPath).LocalPath)
                       .TrimEnd(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar);
        }
    }
}
