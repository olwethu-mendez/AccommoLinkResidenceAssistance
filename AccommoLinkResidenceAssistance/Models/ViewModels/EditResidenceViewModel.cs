using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using AccommoLinkResidenceAssistance.Constants;
using AccommoLinkResidenceAssistance.Models.SystemUsers;

namespace AccommoLinkResidenceAssistance.Models.ViewModels
{
    public class EditResidenceViewModel
    {
        public int? Id { get; set; }

        [Display(Name = "Residence Name")]
        public string? Name { get; set; }

        [ForeignKey("LandlordDetails")]
        public int? LandlordId { get; set; }

        [Display(Name = "Address Line 1")]
        public string? AddressLine1 { get; set; }

        [Display(Name = "Address Line 2")]
        public string? AddressLine2 { get; set; }

        [Display(Name = "Suburb")]
        public string? Suburb { get; set; }

        [Display(Name = "Residence NSFAS Accredited")]
        public bool IsNSFASAccreditd { get; set; }

        [Display(Name = "Room Types")]
        public RoomTypes? RoomTypes { get; set; }

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

        [Display(Name = "Available Space")]
        public int? AvailableRooms { get; set; }

        [Display(Name = "Residence has WiFi")]
        public bool HasWifi { get; set; }

        [Display(Name = "Residence has Study Centre")]
        public bool HasStudyCentre { get; set; }

        [Display(Name = "Catering")]
        public Catering? Catering { get; set; }

        [Display(Name = "Buy own electricity")]
        public bool TenantOwnElectricity { get; set; }

        [Required]
        [Display(Name = "Buy own water")]
        public bool TenantOwnWater { get; set; }

        [Display(Name = "InsitutionsServing")]
        List<UniversityDetails>? UniversityDetails { get; set; }

        public Status Status { get; set; } = Status.Pending;

        public virtual LandlordDetails? LandlordDetails { get; set; }
    }
}
