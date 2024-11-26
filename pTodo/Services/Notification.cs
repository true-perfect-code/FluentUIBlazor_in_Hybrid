using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.LocalNotification;

namespace Services
{
    public interface INotificationManagerService
    {
        event EventHandler NotificationReceived;
        void SendNotification(string _tag_ID, string title, string message, DateTime? notifyTime = null);
        void ReceiveNotification(string title, string message);
    }

    public static class Notification
    {
        private static INotificationManagerService notificationManager = Application.Current?.MainPage?.Handler?.MauiContext?.Services.GetService<Services.INotificationManagerService>();

        public static async Task Send(int _NotificationID, string _title, string _msg, DateTime? _notifytime)
        {
            try
            {

            }
            catch (Exception ex)
            {

                throw;
            }
        }

    }
    //internal class Notification
    //{
    //}
}