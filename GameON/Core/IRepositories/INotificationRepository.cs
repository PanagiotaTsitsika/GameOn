using System.Collections.Generic;
using GameON.Core.Models;

namespace GameON.Core.IRepositories
{
    public interface INotificationRepository
    {
        IEnumerable<Notification> GetNotificationsByUser(string userId);
        IEnumerable<UserNotification> GetNotificationsByUserUnRead(string userId);
    }
}
