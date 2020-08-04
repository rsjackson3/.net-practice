using System;

namespace DatingApp.API.Models
{
    public class Ticket
    {
        public int Id {get; set;}
        public string Title {get; set;}
        public string Description {get; set;}
        public DateTime Created {get; set;}
        public DateTime DueDate {get; set;}
        public bool Completed {get; set;}
        public User User {get; set;}
        public int UserId {get; set;}


    }
}