using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using GameON.Core.IRepositories;
using GameON.Core.Models;

namespace GameON.Persistence.Repositories
{
    public class NotificationRepository : INotificationRepository
    {
        private readonly ApplicationDbContext _context;
        public NotificationRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Notification> GetNotificationsByUser(string userId)
        {
            return _context.UserNotifications
                .Where(un => un.UserId == userId)
                .Select(un => un.Notification)
                .Include(n => n.Tournament.Host)
                .ToList();
        }
        public IEnumerable<UserNotification> GetNotificationsByUserUnRead(string userId)
        {
            return _context.UserNotifications
                .Where(un => un.UserId == userId && !un.IsRead)
                .ToList();
        }
    }
}