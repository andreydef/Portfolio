using System.ComponentModel.DataAnnotations;

namespace PortfolioApp.Models
{
    public class Services
    {
        [Key]
        public int Id { get; set; }

        [StringLength(maximumLength: 40, ErrorMessage = "Максимальна довжина введеної стрічки - 40 символів")]
        [MaxLength(40)]
        public string Title { get; set; }

        public string Short_desc { get; set; }

        public string ImageName { get; set; }

        [Required]
        [StringLength(maximumLength: 40, ErrorMessage = "Максимальна довжина введеної стрічки - 40 символів")]
        [MaxLength(40)]
        public string Title_service { get; set; }

        public string Description { get; set; }
    }
}