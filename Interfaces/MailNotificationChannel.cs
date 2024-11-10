namespace Interfaces
{
    public class MailNotificationChannel : INotificationChanel
    {
        public void Send(Message message)
        {
            System.Console.WriteLine("Sending Emials...");
        }
    }
}
