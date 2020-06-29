using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PortfolioApp.Models
{
    public class About
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "Максимальна довжина введеної стрічки - 50 символів")]
        [MaxLength(50)]
        public string Title { get; set; }
        public string ImageName { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Profile_desc { get; set; }

        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "Максимальна довжина введеної стрічки - 50 символів")]
        [MaxLength(50)]
        public string FullName { get; set; }

        [Required]
        public string Birth_date { get; set; }

        [Required]
        public string Job { get; set; }

        [Required]
        public string Website { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Skills_desc { get; set; }

        [ForeignKey("Skill_key")]
        public int Skill_key { get; set; }
    }
}