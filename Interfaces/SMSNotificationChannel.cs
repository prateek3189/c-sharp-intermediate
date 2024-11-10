namespace Interfaces
{
    public class SMSNotificationChannel : INotificationChanel
    {
        public void Send(Message message)
        {
            System.Console.WriteLine("Sending SMS...");
        }
    }
}
