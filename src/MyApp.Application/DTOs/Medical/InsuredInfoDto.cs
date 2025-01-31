using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Application.DTOs.Medical
{
    public class InsuredInfoDto
    {
        public string? LastName { get; set; }
        public string? FirstName { get; set; }
        public required AddressDto Address { get; set; }
        public string? GroupNumber { get; set; }
    }
}
