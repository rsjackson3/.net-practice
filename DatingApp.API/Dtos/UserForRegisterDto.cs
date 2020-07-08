using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    // a DTO is used to collect data to be returned to the client from the backend 
    public class UserForRegisterDto
    {
        [Required]
        public string Username {get; set;}

        [Required]
        [StringLength(8, MinimumLength = 4, ErrorMessage = "Password must be between 4 and 8 characters")]
        public string Password {get; set;}
    }
}