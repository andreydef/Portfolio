using System.ComponentModel.DataAnnotations;

namespace PortfolioApp.Models.Main_models
{
    public class Stats
    {
        [Key]
        public int Id { get; set; }

        public string ImageName { get; set; }

        public int Count { get; set; }

        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "Максимальна довжина введеної стрічки - 50 символів")]
        [MaxLength(50)]
        public string Title { get; set; }
    }
}