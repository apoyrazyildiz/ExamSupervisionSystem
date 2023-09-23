using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSupervisionSystem.Application.Services
{
    internal class NotificationService
    {
        // Kullanıcıların bildirimlerini saklamak için bir veritabanı veya koleksiyon kullanılabilir.
        private List<Notification> notifications;

        public NotificationService()
        {
            // Bildirimleri saklamak için bir liste veya başka bir depo oluşturulabilir.
            notifications = new List<Notification>();
        }

        public void SendNotification(int userId, string message)
        {
            // Bildirim gönderme işlemini gerçekleştirir.
            // Veritabanına veya bildirim koleksiyonuna yeni bir bildirim ekler.
            var notification = new Notification
            {
                UserId = userId,
                Message = message,
                Timestamp = DateTime.Now
            };
            notifications.Add(notification);
        }

        public IEnumerable<Notification> GetNotifications(int userId)
        {
            // Belirli bir kullanıcının bildirimlerini alır.
            // Kullanıcıya gönderilen bildirimleri filtrelemek için kullanılır.
            return notifications.Where(n => n.UserId == userId);
        }
    }
}
