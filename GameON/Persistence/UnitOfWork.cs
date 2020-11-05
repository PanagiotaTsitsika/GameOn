using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GameON.Core.IRepositories;
using GameON.Persistence.Repositories;

namespace GameON.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public ITournamentRepository Tournaments { get; private set; }
        public IParticipationRepository Participations { get; private set; }
        public IGameRepository Games { get; private set; }
        public INotificationRepository Notifications { get; private set; }
        public IUserNotificationRepository UserNotifications { get; private set; }
        public ICreditCardRepository CreditCards { get; private set; }


        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Tournaments = new TournamentRepository(context);
            Participations = new ParticipationRepository(context);
            Games = new GameRepository(context);
            Notifications = new NotificationRepository(context);
            UserNotifications = new UserNotificationRepository(context);
            CreditCards = new CreditCardRepository(context);
        }


        public int Complete()
        {
            return _context.SaveChanges();

        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}