using System.ComponentModel.DataAnnotations;

namespace PortfolioApp.Models
{
    public class Resume
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(maximumLength: 40, ErrorMessage = "Максимальна довжина введеної стрічки - 40 символів")]
        [MaxLength(40)]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }
    }
}