using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Application.DTOs.Medical
{
    public class ProviderInfoDto
    {
        public string Name { get; set; }
        public string FederalTaxId { get; set; }
        public required AddressDto Address { get; set; }
        public string? NpiNumber { get; set; }
        public string? Phone { get; set; }
    }
}
