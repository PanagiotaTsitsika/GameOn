using System.Collections.Generic;
using System.Linq;
using GameON.Core.IRepositories;
using GameON.Core.Models;

namespace GameON.Persistence.Repositories
{
    public class UserNotificationRepository : IUserNotificationRepository
    {
        private readonly ApplicationDbContext _context;
        public UserNotificationRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public List<UserNotification> GetUserNotificationsUnRead(string userId)
        {
            return _context.UserNotifications
                .Where(un => un.UserId == userId && !un.IsRead)
                .ToList();
        }
    }
}