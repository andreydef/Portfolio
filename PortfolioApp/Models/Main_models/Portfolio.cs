using System.ComponentModel.DataAnnotations;

namespace PortfolioApp.Models.Main_models
{
    public class Portfolio
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }
    }
}