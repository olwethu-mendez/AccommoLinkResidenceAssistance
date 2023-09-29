using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using AccommoLinkResidenceAssistance.Constants;
using Microsoft.AspNetCore.Identity;

namespace AccommoLinkResidenceAssistance.Areas.Identity.Data;

// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser
{
    [Required]
    [Display(Name="Username")]
    public override string UserName { get; set; }
    [Required]
    [Display(Name = "Full Name/Institution")]
    [StringLength(120, ErrorMessage = "The {0} must be at least {2} and at a max {1} characters long.", MinimumLength = 2)]
    public string Name { get; set; }

    [PersonalData]
    [Display(Name = "Email Address")]
    [EmailAddress]
    public override string Email { get; set; }

    [Required]
    [PersonalData]
    [Display(Name = "Phone Number")]
    [StringLength(10, ErrorMessage = "Standard phone number can only be 10 digits long.", MinimumLength = 10)] //datatype must be number in view/html
    public override string PhoneNumber { get; set; }

    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; }

    [Required]
    [Compare("Password", ErrorMessage = "Confirm password doesn't match, Type again !")]
    [DataType(DataType.Password)]
    [Display(Name = "Confirm Password")]
    public string ConfirmPassword { get; set; }

    [Display(Name = "Date Created On")]
    public DateTime CreatedOn { get; set; } = DateTime.Now;
    [Display(Name = "User Role")]
    public UserRole UserRole { get; set; }

    [PersonalData]
    [Display(Name = "Profile Picture/Logo")]
    public string? ProfilePicture { get; set; }

    [NotMapped]
    [Display(Name = "Upload Image File")]
    public IFormFile? ImageFile { get; set; }

    public bool Status { get; set; }
}

