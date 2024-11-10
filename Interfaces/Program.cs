namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // Polymorphism
            var encoder = new VideoEncoder();
            encoder.RegisterNotificationChannel(new MailNotificationChannel());
            encoder.RegisterNotificationChannel(new SMSNotificationChannel());
            encoder.Encode(new Video());

            // Extensability
            // var dbMigrator = new DBMigrator(new ConsoleLogger());
            // dbMigrator.Migrate();

            // Interfaces
            // var orderProcessor = new OrderProcessor(new ShippingCalculator());
            // var order = new Order { DatePlaced = DateTime.Now, TotalOrderIeee754Comparer = 100f };
            // orderProcessor.Process(order);
        }
    }
}
