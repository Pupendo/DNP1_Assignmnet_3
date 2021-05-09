using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class Account
    {
        [Key]
        public string Username { get; set; }
        [Required, MaxLength(20)]
        public string Password { get; set; }
        
        [Required, MaxLength(20)]
        public string Role { get; set; }
    }
}