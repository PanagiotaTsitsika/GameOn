using System;

namespace GameON.Core.Dtos
{
    public class TournamentDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
      
        public UserDto Host { get; set; }
        
        public DateTime DateTime { get; set; }
       
        public GameDto Game { get; set; }
        public string Description { get; set; }
       
        public string Venue { get; set; }

        public bool IsCancelled { get; set; }
    }
}