using System.ComponentModel.DataAnnotations;

namespace PortfolioApp.Models.Main_models
{
    public class Service_info
    {
        [Key]
        public int Id { get; set; }

        public string ImageName { get; set; }

        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "Максимальна довжина введеної стрічки - 50 символів")]
        [MaxLength(50)]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }
    }
}