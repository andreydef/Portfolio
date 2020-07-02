using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Windows.Markup;

namespace PortfolioApp.Models
{
    public class Languages
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(maximumLength: 20, ErrorMessage = "Максимальна довжина введеної стрічки - 20 символів")]
        [MaxLength(20)]
        public string Title { get; set; }

        [Required]
        [StringLength(maximumLength: 2, ErrorMessage = "Максимальна довжина введеної стрічки - 2 символів")]
        [MaxLength(2)]
        public int Raiting { get; set; }
    }
}