using System.Collections.Generic;
using GameON.Core.Models;

namespace GameON.Core.IRepositories
{
    public interface IUserNotificationRepository
    {
        List<UserNotification> GetUserNotificationsUnRead(string userId);
    }
}
