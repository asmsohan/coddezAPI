using System.ComponentModel.DataAnnotations;

namespace SendEmailInAspNetCore.Models
{
    public class ContactViewModel
    {
        [Required]
        [StringLength(60, MinimumLength = 5)]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string password { get; set; }
        [Required]
        public string Subject { get; set; }
        [Required]
        public string Message { get; set; }
    }
}