using System;
using System.Collections.Generic;

namespace Constructors
{
    public class Customer
    {
        public int id = 0;
        public string Name = "";
        public readonly List<Order> Orders = new List<Order>();

        public Customer(int id)
        {
            this.id = id;
        }

        public Customer(int id, string Name)
            : this(id)
        {
            this.Name = Name;
        }

        public void Promote() { }
    }
}
