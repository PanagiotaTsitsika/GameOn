using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using GameON.Core.Models;

namespace GameON.Persistence
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {

       public DbSet<Game> Games { get; set; }
        public DbSet<Genre> Genres{ get; set; }
        public DbSet<Tournament> Tournaments { get; set; }
        public DbSet<Participation> Participations { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<UserNotification> UserNotifications { get; set; }
        public DbSet<CreditCard> CreditCards { get; set; }

        public ApplicationDbContext() : base("GameONContext", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
        //FLUENT API
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApplicationUser>()
                .HasOptional(u => u.CreditCard)
                .WithRequired(cd => cd.User);

            modelBuilder.Entity<Participation>()
                .HasRequired(p => p.Tournament)
                .WithMany(t=>t.Participations)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UserNotification>()
                .HasRequired(a => a.User)
                .WithMany(u=>u.UserNotifications)
                .WillCascadeOnDelete(false);

            base.OnModelCreating(modelBuilder);
        }
    }
}