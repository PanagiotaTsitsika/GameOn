using System;

namespace GameON.Core.IRepositories
{
    public interface IUnitOfWork :IDisposable
    {
        ITournamentRepository Tournaments { get; }
        IParticipationRepository Participations { get; }
        IGameRepository Games { get; }
        INotificationRepository Notifications { get; }
        IUserNotificationRepository UserNotifications { get; }
        ICreditCardRepository CreditCards { get; }
        int Complete();
        
    }
}
