using MyApp.Domain.Enums.Medical;
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
    public class PatientInfo
    {
        [MaxLength(50)]
        public required string LastName { get; set; }
        [MaxLength(50)]
        public required string FirstName { get; set; }
        public DateTime BirthDate { get; set; }
        public Sex Sex { get; set; }
        public required Address Address { get; set; }
        public Relationship RelationshipToInsured { get; set; }
    }
}
