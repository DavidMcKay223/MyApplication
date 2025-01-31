using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Infrastructure.ExternalServices.NPI.DTO
{
    internal class Root
    {
        public int Result_count { get; set; }
        public List<Result>? Results { get; set; }
        public List<Error>? Errors { get; set; }
    }
}
