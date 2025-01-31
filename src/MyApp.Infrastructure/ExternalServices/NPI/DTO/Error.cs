using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Infrastructure.ExternalServices.NPI.DTO
{
    public class Error
    {
        public string? Description { get; set; }
        public string? Field { get; set; }
        public string? Number { get; set; }
    }
}
