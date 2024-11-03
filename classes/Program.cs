using System;
using System.Globalization;

namespace Constructors
{
    public class Program
    {
        static void Main(string[] args)
        {
            var dbMigrator = new DBMigrator(new Logger());
            var installer = new Installer(new Logger());

            dbMigrator.Migrate();
            installer.Install();

            // var text = new Text();
            // text.AddHyperLink("http://google.com");
            // text.Copy();
            // text.Duplicate();
            // text.FontName = "sans-serif";
            // text.FontSize = 12;
            // text.Height = 50;
            // text.Width = 50;

            // var cookie = new HttpCookie();
            // cookie["name"] = "Prateek";
            // System.Console.WriteLine(cookie["name"]);

            // UsePoints();

            // UseParams();

            // var customer = new Customer(1);
            // customer.Orders.Add(new Order());
            // customer.Orders.Add(new Order());

            // customer.Promote();

            // System.Console.WriteLine(customer.Orders.Count);

            // var person = new Person(new DateTime(1989, 3, 1));
            // System.Console.WriteLine(person.Age);
        }

        static void UseParams()
        {
            var calculator = new Calculator();
            // var result = calculator.Add(new int[] { 1, 2, 3, 4, 5 });
            var result = calculator.Add(1, 2, 3, 4, 5);
            System.Console.WriteLine(result);
        }

        static void UsePoints()
        {
            try
            {
                // Point
                var point = new Point(10, 20);
                point.Move(new Point(40, 60));

                System.Console.WriteLine(point.x);
                System.Console.WriteLine(point.y);

                point.Move(100, 200);
                System.Console.WriteLine(point.x);
                System.Console.WriteLine(point.y);
            }
            catch (Exception)
            {
                System.Console.WriteLine("An unexpected error!!");
            }

            // Method
            // var customer = new Customer(3, "Prateek Magarde");
            // var order = new Order();
            // customer.Orders.Add(order);
            // System.Console.WriteLine(customer.id);
            // System.Console.WriteLine(customer.Name);
        }
    }
}
