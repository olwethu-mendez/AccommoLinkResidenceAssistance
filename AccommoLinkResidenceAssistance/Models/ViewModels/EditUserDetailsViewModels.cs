using AccommoLinkResidenceAssistance.Constants;
using AccommoLinkResidenceAssistance.Models.SystemUsers;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace AccommoLinkResidenceAssistance.Models.ViewModels
{
    public class EditUserDetailsViewModels
    {
        [ForeignKey("Landlord")]
        public int? LandlordId { get; set; }
        [ForeignKey("Student")]
        public int? StudentId { get; set; }
        [ForeignKey("University")]
        public int? UniversityId { get; set; }

        public string? TelNumber { get; set; }
        public string? FaxNumber { get; set; }

        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? HomeTel { get; set; }
        public string? EmergencyContact { get; set; }
        public string? EmergencyContactNr { get; set; }
        public bool? Employed { get;}
        public string? WorkTel { get; set; }
        public string? WorkEmail { get; set; }
        public MaritalStatus? MaritalStatus { get; set; }
        public string? AddressLine1 { get; set; }
        public string? AddressLine2 { get; set; }
        public string? Suburb { get; set; }
        public string? City { get; set; }
        public Provinces? Province { get; set; }
        public string? ZipCode { get; set; }
        [ForeignKey("University")]
        public int? StudentUniversityId { get; set; }
        [ForeignKey("UniversityCampus")]
        public int? StudentUniversityCampusId { get; set; }
        public bool? Status { get; set; } = false;

        public virtual UniversityCampuses? UniversityCampus { get; set; }

        public virtual LandlordDetails? Landlord { get; set; }
        public virtual StudentDetails? Student { get; set; }
        public virtual UniversityDetails? University { get; set; }
    }
}
