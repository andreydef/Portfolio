using System.ComponentModel.DataAnnotations;

namespace PortfolioApp.Models.Main_models
{
    public class Links
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Link_facebook { get; set; }

        [Required]
        public string Link_github { get; set; }

        [Required]
        public string Link_twitter { get; set; }

        [Required]
        public string Link_instagram { get; set; }
    }
}