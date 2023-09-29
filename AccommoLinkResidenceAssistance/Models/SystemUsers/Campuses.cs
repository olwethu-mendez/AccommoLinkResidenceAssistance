using System.ComponentModel.DataAnnotations;

namespace AccommoLinkResidenceAssistance.Models.SystemUsers
{
    public class Campuses
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string CampusName { get; set; }
        [Required]
        public string CampusFaculties { get; set; }

        public List<UniversityCampuses>? UniversityCampuses { get; set; }
    }
}
