using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Infrastructure.ExternalServices.NPI.DTO
{
    internal class Basic
    {
        public string? Organization_name { get; set; }
        public string? Organizational_subpart { get; set; }
        public string? Enumeration_date { get; set; }
        public string? Last_updated { get; set; }
        public string? Certification_date { get; set; }
        public string? Status { get; set; }
        public string? Authorized_official_first_name { get; set; }
        public string? Authorized_official_last_name { get; set; }
        public string? Authorized_official_telephone_number { get; set; }
        public string? Authorized_official_title_or_position { get; set; }
        public string? Authorized_official_name_prefix { get; set; }
        public string? Authorized_official_name_suffix { get; set; }
        public string? Authorized_official_credential { get; set; }
        public string? Authorized_official_middle_name { get; set; }
        public string? First_name { get; set; }
        public string? Last_name { get; set; }
        public string? Middle_name { get; set; }
        public string? Sole_proprietor { get; set; }
        public string? Gender { get; set; }
        public string? Name_prefix { get; set; }
        public string? Parent_organization_legal_business_name { get; internal set; }
        public string? Name { get; internal set; }
    }
}
