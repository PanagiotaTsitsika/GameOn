using System;
using System.ComponentModel.DataAnnotations;

namespace GameON.Core.Models
{
    public class Notification
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public NotificationType Type { get; private set; }
        public DateTime? OriginalDateTime { get; set; }
        public string OriginalVenue { get; set; }
        //public string OriginalTitle { get; set; }
        [Required]
        public Tournament Tournament { get; private set; }
        protected Notification()
        { }
        private Notification(Tournament tournament, NotificationType type)
        {
            if (tournament is null)
                throw new ArgumentNullException("tournament");
            Tournament = tournament;
            Type = type;
            DateTime = DateTime.Now;
        }
        public static Notification TournamentCanceled(Tournament tournament)
        {
            return new Notification(tournament, NotificationType.TournamentCanceled);
        }
        public static Notification TournamentCreated(Tournament tournament)
        {
            return new Notification(tournament, NotificationType.TournamentCreated);
        }
        public static Notification TournamentUpdated(Tournament newTour, DateTime origDateTime, string origVenue, string origTitle)
        {
            var notification = new Notification(newTour, NotificationType.TournamentUpdated);

            //notification.OriginalTitle = origTitle;
            notification.OriginalDateTime = origDateTime;
            notification.OriginalVenue = origVenue;

            return notification;
        }

    }
}