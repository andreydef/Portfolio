using System;
using System.ComponentModel.DataAnnotations;

namespace PortfolioApp.Models
{
    public class Projects
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        [Required]
        [StringLength(maximumLength: 40, ErrorMessage = "Максимальна довжина введеної стрічки - 40 символів")]
        [MaxLength(40)]
        public string Name_project { get; set; }

        [Required]
        public DateTime Date_project { get; set; }

        public string ImageName { get; set; }
    }
}