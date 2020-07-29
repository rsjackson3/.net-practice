using System;
using System.Collections.Generic;

namespace DatingApp.API.Models
{
    public class User
    {
        public int Id {get; set;}
        public string Username {get; set;}
        public byte[] PasswordHash {get; set;}
        public byte[] PasswordSalt {get; set;}
        public string Gender {get; set;}
        public DateTime DateOfBirth {get; set;}
        public string KnownAs {get; set;}
        public DateTime LastActive {get; set;}
        public string City {get; set;}
        public ICollection<Photo> Photos {get; set;} // use convention for relations between classes

    }
}