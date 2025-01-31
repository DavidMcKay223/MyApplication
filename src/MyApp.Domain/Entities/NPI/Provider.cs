using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Domain.Entities.NPI
{
    [Table("NPI_Provider")]
    [Serializable]
    public class Provider
    {
        [Key]
        #region -- NPI Number --
        [MaxLength(10)]
        public required string NPI { get; set; }
        #endregion

        #region -- Address Info --
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Zip { get; set; }
        public string? Phone { get; set; }
        public string? Fax { get; set; }
        #endregion

        #region -- Mailing Address Info --
        public string? MailingAddress1 { get; set; }
        public string? MailingAddress2 { get; set; }
        public string? MailingCity { get; set; }
        public string? MailingState { get; set; }
        public string? MailingZip { get; set; }
        public string? MailingPhone { get; set; }
        public string? MailingFax { get; set; }
        #endregion

        #region -- Basic Info --
        public string? Name { get; set; }
        public string? ProviderName { get; set; }
        public string? ProviderFirstName { get; set; }
        public string? ProviderLastName { get; set; }
        public string? OrganizationName { get; set; }
        public string? ParentOrganizationLegalBusinessName { get; set; }
        public string? Gender { get; set; }
        public string? SoleProprietor { get; set; }
        public string? EnumerationDate { get; set; }
        public string? LastUpdated { get; set; }
        public string? Status { get; set; }
        #endregion

        #region -- Other Names --
        public string? OtherOrganizationName { get; set; }
        #endregion

        #region -- Taxonomy --
        public string? PrimaryTaxonomyCode { get; set; }
        public string? PrimaryTaxonomyStateLicense { get; set; }
        public string? PrimaryTaxonomyDescription { get; set; }
        public string? PrimaryTaxonomyGroup { get; set; }
        #endregion

        #region -- Identifiers --
        public List<Identifier>? Identifiers { get; set; }
        #endregion

        #region -- Endpoints --
        public List<Endpoint>? Endpoints { get; set; }
        #endregion
    }
}
