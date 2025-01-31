using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MyApp.Domain.Entities.Medical
{
    [Owned]
    public class ProviderInfo
    {
        [MaxLength(100)]
        public required string Name { get; set; }
        [MaxLength(20)]
        public required string FederalTaxId { get; set; }
        public required Address Address { get; set; }
        [MaxLength(20)]
        public string? NpiNumber { get; set; }
        [MaxLength(20)]
        public string? Phone { get; set; }
    }
}
