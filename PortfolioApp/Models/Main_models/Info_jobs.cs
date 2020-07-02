﻿using System.ComponentModel.DataAnnotations;

namespace PortfolioApp.Models
{
    public class Info_jobs
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Numbers { get; set; }

        [Required]
        [StringLength(maximumLength: 40, ErrorMessage = "Максимальна довжина введеної стрічки - 40 символів")]
        [MaxLength(40)]
        public string Title { get; set; }

        public string ImageName { get; set; }
    }
}