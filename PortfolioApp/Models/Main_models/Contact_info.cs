using System.ComponentModel.DataAnnotations;

namespace PortfolioApp.Models
{
    public class Contact_info
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(maximumLength: 40, ErrorMessage = "Максимальна довжина введеної стрічки - 40 символів")]
        [MaxLength(40)]
        public string Title { get; set; }

        [Required]
        public string Short_desc { get; set; }

        public string ImageName { get; set; }

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