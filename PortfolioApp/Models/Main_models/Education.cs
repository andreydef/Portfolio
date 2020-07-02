using System;
using System.ComponentModel.DataAnnotations;

namespace PortfolioApp.Models
{
    public class Education
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(maximumLength: 40, ErrorMessage = "Максимальна довжина введеної стрічки - 40 символів")]
        [MaxLength(40)]
        public string Name_education { get; set; }

        [Required]
        public DateTime Date_start { get; set; }

        [Required]
        public DateTime Date_finish { get; set; }

        [Required]
        [StringLength(maximumLength: 40, ErrorMessage = "Максимальна довжина введеної стрічки - 40 символів")]
        [MaxLength(40)]
        public string Title_place { get; set; }

        public string Description { get; set; }
    }
}