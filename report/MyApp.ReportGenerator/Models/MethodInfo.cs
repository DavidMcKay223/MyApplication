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
        /// Method name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Return type of the method.
        /// </summary>
        public string ReturnType { get; set; }

        /// <summary>
        /// List of parameters and their types.
        /// </summary>
        public List<ParameterInfo> Parameters { get; set; } = new List<ParameterInfo>();

        /// <summary>
        /// Access modifier (public, private, etc.).
        /// </summary>
        public string AccessModifier { get; set; }

        /// <summary>
        /// Indicates whether the method is static.
        /// </summary>
        public bool IsStatic { get; set; }
    }
}
