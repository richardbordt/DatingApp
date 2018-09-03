using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }
        
        
        [Required]
        [StringLength(8, MinimumLength = 4, ErrorMessage = "Passwort muss zwischen 4 und 8 Zeichen erhalten")]
        public string Password { get; set; }
    }
}