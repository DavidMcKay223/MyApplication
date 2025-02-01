using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.ReportGenerator.Models
{
    public class PropertyInfo
    {
        /// <summary>
        /// The name of the property.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The type of the property.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// The full code of the property.
        /// </summary>
        public string CodeSnippet { get; set; }
    }
}
