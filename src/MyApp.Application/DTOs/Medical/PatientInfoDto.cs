using MyApp.Domain.Enums.Medical;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Application.DTOs.Medical
{
    public class PatientInfoDto
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime? BirthDate { get; set; }
        public Sex Sex { get; set; }
        public required AddressDto Address { get; set; }
        public Relationship RelationshipToInsured { get; set; }
    }
}
