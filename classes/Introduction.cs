using System;

namespace Classes
{
    public class Person
    {
        public string Name = "";

        public void Introduction(string to)
        {
            Console.WriteLine("Hi {0}, I am {1} ", to, this.Name);
        }

        public static Person Parse(string str)
        {
            var person = new Person();
            person.Name = str;
            return person;
        }
    }
}
