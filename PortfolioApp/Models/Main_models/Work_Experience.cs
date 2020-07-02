using System;
using System.ComponentModel.DataAnnotations;

namespace PortfolioApp.Models
{
    public class Work_Experience
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(maximumLength: 40, ErrorMessage = "Максимальна довжина введеної стрічки - 40 символів")]
        [MaxLength(40)]
        public string Name_job { get; set; }

        [Required]
        public DateTime Date_start { get; set; }

        [Required]
        public DateTime Date_finish { get; set; }

        [Required]
        public string Title_job { get; set; }

        public string Description { get; set; }
    }
}