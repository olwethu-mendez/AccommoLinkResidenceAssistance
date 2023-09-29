using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AccommoLinkResidenceAssistance.Models.SystemUsers
{
    public class UniversityCampuses
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey("Campus")]
        public int CampusId { get; set; }
        [Required]
        [ForeignKey("University")]
        public int UniversityId { get; set; }

        public Campuses? Campus { get; set; }
        public UniversityDetails? University { get; set; }
    }
}