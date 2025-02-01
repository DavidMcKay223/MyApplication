using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.ReportGenerator.Models
{
    public class MethodInfo
    {
        /// <summary>
        /// The name of the method.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The return type of the method.
        /// </summary>
        public string ReturnType { get; set; }

        /// <summary>
        /// List of parameters for the method.
        /// </summary>
        public List<ParameterInfo> Parameters { get; set; } = new List<ParameterInfo>();

        /// <summary>
        /// Access modifier of the method (public, private, etc.).
        /// </summary>
        public string AccessModifier { get; set; }

        /// <summary>
        /// Indicates whether the method is static.
        /// </summary>
        public bool IsStatic { get; set; }

        /// <summary>
        /// The full code of the method.
        /// </summary>
        public string CodeSnippet { get; set; }
    }
}
