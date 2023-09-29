using AccommoLinkResidenceAssistance.Areas.Identity.Data;
using AccommoLinkResidenceAssistance.Constants;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AccommoLinkResidenceAssistance.Models.SystemUsers
{
    public class LandlordDetails
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }

        [Required]
        [PersonalData]
        [Display(Name = "ID Number")]
        [StringLength(13, ErrorMessage = "The {0} must strictly be {1} characters long.", MinimumLength = 13)]
        public string IdNumber { get; set; }

        [Required]
        [PersonalData]
        public Titles Title { get; set; }

        [Required]
        [PersonalData]
        [Display(Name = "First Name")]
        public int FirstName { get; set; }

        [Required]
        [PersonalData]
        [Display(Name = "Middle Name")]
        public int MiddleName { get; set; }

        [Required]
        [PersonalData]
        [Display(Name = "Last Name")]
        public int LastName { get; set; }

        [Required]
        [PersonalData]
        [Display(Name = "Email Address")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [PersonalData]
        [Display(Name = "Phone Number")]
        [StringLength(10, ErrorMessage = "Standard phone number can only be 10 digits long.", MinimumLength = 10)] //datatype must be number in view/html
        public string PhoneNumber { get; set; }

        [Required]
        [PersonalData]
        public Gender Gender { get; set; }

        [Required]
        [PersonalData]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MMM/yyyy}")]
        [DataType(DataType.Date)]
        [Display(Name = "Date of Birth")]
        public DateTime? DOB { get; set; }

        [PersonalData]
        [Display(Name = "Home Telephone")]
        public string? HomeTel { get; set; }

        [Required]
        [PersonalData]
        [Display(Name = "Emergency Contact Person (Full Name)")]
        public string EmergencyContact { get; set; }

        [Required]
        [PersonalData]
        [Display(Name = "Emergency Contact Number")]
        [StringLength(10, ErrorMessage = "Standard phone number can only be 10 digits long.", MinimumLength = 10)]
        public string EmergencyContactNr { get; set; }

        [Required]
        [PersonalData]
        [Display(Name = "Employment Status")]
        public bool Employed { get; set; }

        [PersonalData]
        [Display(Name = "Work Telephone")]
        public string? WorkTel { get; set; }

        [PersonalData]
        [Display(Name = "Work Email")]
        public string? WorkEmail { get; set; }

        [PersonalData]
        [Required]
        public Citizenship Citizenship { get; set; }

        [Required]
        [PersonalData]
        [Display(Name = "Marital Status")]
        public MaritalStatus MaritalStatus { get; set; }

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
        public bool Status { get; set; } = false;


        public virtual ApplicationUser? User { get; set; }
    }
}
