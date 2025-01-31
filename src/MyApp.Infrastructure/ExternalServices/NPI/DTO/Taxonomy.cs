using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Infrastructure.ExternalServices.NPI.DTO
{
    internal class Taxonomy
    {
        public string? Code { get; set; }
        public string? Taxonomy_group { get; set; }
        public string? Desc { get; set; }
        public string? State { get; set; }
        public string? License { get; set; }
        public bool Primary { get; set; }
    }
}
