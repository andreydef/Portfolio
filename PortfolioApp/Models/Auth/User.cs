using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PortfolioApp.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        [PasswordPropertyText()]
        public string Password { get; set; }

        [Required]
        public string UserType { get; set; }
    }
}