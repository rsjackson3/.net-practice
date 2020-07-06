namespace DatingApp.API.Dtos
{
    // a DTO is used to collect data to be returned to the client from the backend 
    public class UserForRegisterDto
    {
        public string Username {get; set;}
        public string Password {get; set;}
    }
}