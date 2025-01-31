using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Infrastructure.ExternalServices.NPI.DTO
{
    internal class Address
    {
        public string? Country_code { get; set; }
        public string? Country_name { get; set; }
        public string? Address_purpose { get; set; }
        public string? Address_type { get; set; }
        public string? Address_1 { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Postal_code { get; set; }
        public string? Telephone_number { get; set; }
        public string? Fax_number { get; set; }
        public string? Address_2 { get; set; }
    }
}
