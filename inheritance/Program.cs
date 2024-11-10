// using Amazon;

using System.Collections;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new ArrayList();
            list.Add(1);
            list.Add("Mosh");
            list.Add(DateTime.Today);

            var anotherList = new List<int>();
            anotherList.Add(1);
            // anotherList.Add("1"); - Invalid

            // Shape shape = new Text();
            // Text text = (Text)shape;

            // StreamReader reader = new StreamReader(new MemoryStream());

            // var car = new Car("MH12MW9569");

            // var customer = new Customer();
            // customer.Promote();
        }
    }
}
