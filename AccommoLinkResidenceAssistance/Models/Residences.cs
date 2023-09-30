using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using AccommoLinkResidenceAssistance.Constants;
using AccommoLinkResidenceAssistance.Models.SystemUsers;
using System.Drawing.Drawing2D;

namespace AccommoLinkResidenceAssistance.Models
{
    public class Residences
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Residence Name")]
        public string Name { get; set; }

        [Required]
        [ForeignKey("LandlordDetails")]
        public int LandlordId { get; set; }

        [Display(Name = "Residence Picture")]
        public string ResidencePicture { get; set; }

        [NotMapped]
        [Display(Name = "Upload Image File")]
        public IFormFile ImageFile { get; set; }

        [Required]
        [Display(Name = "Address Line 1")]
        public string AddressLine1 { get; set; }

        [Display(Name = "Address Line 2")]
        public string? AddressLine2 { get; set; }

        [Display(Name = "Suburb")]
        public string? Suburb { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public Provinces Province { get; set; }

        [Required]
        [Display(Name ="Zip Code")]
        public string ZipCode { get; set; }

        [Required]
        [Display(Name="Residence NSFAS Accredited")]
        public bool IsNSFASAccreditd { get; set; }

        [Required]
        [Display(Name ="Room Types")]
        public RoomTypes RoomTypes { get; set; }

        //should be hidden until options are made above
        //top up prices hidden unless res is nsfas accredited

        [Display(Name = "Single Room Prices")]
        public float? SinglePrice { get; set; }

        [Display(Name = "Single Room Top-up Prices")]
        public float? SingleTopUp { get; set; }

        [Display(Name = "Single Ensuite Room Prices")]
        public float? SingleEnsuitePrice { get; set; }

        [Display(Name = "Single Ensuite Room Top-up Prices")]
        public float? SingleEnsuiteTopUp { get; set; }

        [Display(Name = "Sharing Room Prices")]
        public float? SharingPrice { get; set; }

        [Display(Name = "Sharing Ensuite Room Prices")]
        public float? SharingEnsuitePrice { get; set; }

        [Display(Name = "Sharing Ensuite Room Top-up Prices")]
        public float? SharingEnsuiteTopUp { get; set; }

        [Required]
        [Display(Name = "Available Space")]
        public int AvailableRooms { get; set; }

        [Required]
        [Display(Name = "Residence has WiFi")]
        public bool HasWifi { get; set; }

        [Required]
        [Display(Name = "Residence has Study Centre")]
        public bool HasStudyCentre { get; set; }

        [Required]
        [Display(Name="Catering")]
        public Catering Catering { get; set; }

        [Required]
        [Display(Name = "Buy own electricity")]
        public bool TenantOwnElectricity { get; set; }

        [Required]
        [Display(Name = "Buy own water")]
        public bool TenantOwnWater { get; set; }

        [Display(Name = "InsitutionsServing")]
        List<UniversityDetails>? UniversityDetails { get; set; }

        [Required]
        public Status Status { get; set; } = Status.Pending;

        public virtual LandlordDetails? LandlordDetails { get; set; }

    }
}
