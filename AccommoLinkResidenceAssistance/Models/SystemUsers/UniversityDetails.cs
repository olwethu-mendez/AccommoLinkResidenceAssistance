using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using AccommoLinkResidenceAssistance.Constants;
using AccommoLinkResidenceAssistance.Areas.Identity.Data;
using AccommoLinkResidenceAssistance.Models.SystemUsers;

namespace AccommoLinkResidenceAssistance.Models.SystemUsers
{
    public class UniversityDetails
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }

        [Required]
        [PersonalData]
        [Display(Name = "Institution Registration Number")]
        [StringLength(13, ErrorMessage = "The {0} must strictly be {1} characters long.", MinimumLength = 13)] //####/XX##/###
        public string RegistrationNumber { get; set; }

        [Required]
        [PersonalData]
        [Display(Name ="Institution Name")]
        public string Name { get; set; }

        [Required]
        [PersonalData]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{dd/MMM/yyyy}")]
        [Display(Name ="Date Founded")]
        public DateTime Founded { get; set; }

        [Required]
        [PersonalData]
        public string Motto { get; set; }

        [Required]
        [PersonalData]
        [Display(Name = "Telephone Number")]
        [StringLength(10, ErrorMessage = "Standard phone number can only be 10 digits long.", MinimumLength = 10)] //datatype must be number in view/html
        public string TelNumber { get; set; }

        [Required]
        [PersonalData]
        [Display(Name = "Fax Number")]
        [StringLength(10, ErrorMessage = "Standard phone number can only be 10 digits long.", MinimumLength = 10)] //datatype must be number in view/html
        public string FaxNumber { get; set; }

        public List<UniversityCampuses>? UniversityCampuses { get; set; }

        [Required]
        [PersonalData]
        [Display(Name = "Email Address")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [PersonalData]
        [Display(Name = "Address Line 1")]
        public string AddressLine1 { get; set; }

        [PersonalData]
        [Display(Name = "Address Line 2")]
        public string? AddressLine2 { get; set; }

        [PersonalData]
        [Display(Name = "Suburb")]
        public string? Suburb { get; set; }

        [Required]
        [PersonalData]
        public string City { get; set; }

        [Required]
        [PersonalData]
        public Provinces Province { get; set; }

        [Required]
        [PersonalData]
        public string ZipCode { get; set; }

        [Required]
        public Status Status { get; set; } = Status.Pending;


        public virtual ApplicationUser? User { get; set; }
    }
}
