using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace GameON.Core.Models
{
    public class Tournament
    {


        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength: 255, MinimumLength = 3, ErrorMessage = "vale ena sosto megethos GTXS")]
        public string Title { get; set; }
        [Required]
        public string HostId { get; set; }
        public ApplicationUser Host { get; set; }
        [Required]
        public DateTime DateTime { get; set; }
        [Required]
        public int GameId { get; set; }
        public Game Game { get; set; }
        public string Description { get; set; }
        [Required]
        public string Venue { get; set; }

        public bool IsCancelled { get; set; }

        [Display(Name = "Photo")]
        public string ImagePath { get; set; }
        public ICollection<Participation> Participations { get; set; }

        public Tournament()
        {
            Participations = new Collection<Participation>();
        }
        public void Cancel()
        {
            IsCancelled = true;

            var notification = Notification.TournamentCanceled(this);

            foreach (var participant in Participations.Select(p => p.Gamer))
            {
                participant.Notify(notification);
            }
        }
        public void Modify(string title, string description, int gameId, DateTime dateTime, string venue)
        {
            var notification = Notification.TournamentUpdated(this, DateTime, Venue, Title);

            Title = title;
            Description = description;
            GameId = gameId;
            DateTime = dateTime;
            Venue = venue;

            foreach (var participant in Participations.Select(p=>p.Gamer))
            {
                participant.Notify(notification);
            }
        }
    }
}