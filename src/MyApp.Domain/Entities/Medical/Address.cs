using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Domain.Entities.Medical
{
    [Table("Medical_Claim_Address")]
    public class Address
    {
        [Key]
        public int AddressId { get; set; }
        [MaxLength(100)]
        public string? Street { get; set; }
        [MaxLength(50)]
        public string? City { get; set; }
        [MaxLength(2)]
        public string? State { get; set; }
        [MaxLength(10)]
        public string? ZipCode { get; set; }
        [MaxLength(20)]
        public string? Phone { get; set; }
    }
}
