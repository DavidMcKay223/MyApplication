using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.ReportGenerator.Models
{
    public class ClassInfo
    {
        /// <summary>
        /// The name of the class.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The namespace the class belongs to.
        /// </summary>
        public string Namespace { get; set; }

        /// <summary>
        /// File path where the class is defined.
        /// </summary>
        public string FilePath { get; set; }

        /// <summary>
        /// Base classes and interfaces implemented.
        /// </summary>
        public List<string> BaseTypes { get; set; } = new List<string>();

        /// <summary>
        /// Properties defined in the class.
        /// </summary>
        public List<PropertyInfo> Properties { get; set; } = new List<PropertyInfo>();

        /// <summary>
        /// Methods defined in the class.
        /// </summary>
        public List<MethodInfo> Methods { get; set; } = new List<MethodInfo>();

        /// <summary>
        /// The relative path from the project root to the class file.
        /// </summary>
        public string RelativePath { get; set; }

        /// <summary>
        /// The full code of the class.
        /// </summary>
        public string CodeSnippet { get; set; }

        public List<string> Dependencies { get; set; } = new List<string>();

        /// <summary>
        /// The name of the project the class belongs to.
        /// </summary>
        public string ProjectName { get; set; }

        /// <summary>
        /// The subfolder path within the project.
        /// </summary>
        public string SubfolderPath { get; set; }
    }
}
