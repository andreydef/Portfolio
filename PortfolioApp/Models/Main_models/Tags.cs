using System.ComponentModel.DataAnnotations;

namespace PortfolioApp.Models
{
    public class Tags
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(maximumLength: 20, ErrorMessage = "Максимальна довжина введеної стрічки - 20 символів")]
        [MaxLength(20)]
        public string Title { get; set; }
    }
}