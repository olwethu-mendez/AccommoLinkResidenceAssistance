using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AccommoLinkResidenceAssistance.Models
{
    public class ReportResidence
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey("Residences")]
        public int ResidenceId { get; set; }
        [Required]
        public string ResidenceIssue { get; set; }

        public Residences Residences { get; set; }
    }
}
