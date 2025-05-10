using System;

namespace UserManagement.Services
{
    public class NotificationService
    {
        public void SendEmail(string email, string message)
        {
            // Symulacja wysyłania e-maila
            Console.WriteLine($"Sending email to {email}: {message}");
        }
    }
}
