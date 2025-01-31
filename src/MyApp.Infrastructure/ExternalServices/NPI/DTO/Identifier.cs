using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Infrastructure.ExternalServices.NPI.DTO
{
    internal class Identifier
    {
        public string? Code { get; set; }
        public string? Desc { get; set; }
        public string? Issuer { get; set; }
        public string? identifier { get; set; }
        public string? State { get; set; }
    }
}
