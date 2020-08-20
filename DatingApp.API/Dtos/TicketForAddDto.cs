using System;

namespace DatingApp.API.Dtos
{
    // Dto for user to add tickets 
    public class TicketForAddDto
    {
        public string Title {get; set;}
        public string Description {get; set;}
        public DateTime Created {get; set;}
        public DateTime DueDate {get; set;}
        public bool Completed {get; set;}
        public int UserId {get; set;}
    }
}