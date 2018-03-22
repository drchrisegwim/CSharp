using System.Collections.Generic;

namespace _4_Fields
{
    partial class Program
    {
        public class Customer
        {
            public int Id;
            public string Name;

            // Use readonly keword on the field below to avoid someone acidentally reinitialize the value the list item
            public List<Order> Orders;

            public Customer()
            {
                Orders = new List<Order>();
            }

            public Customer(int id)
            : this()
            {
                this.Id = id;
            }

            public Customer(int id, string name)
            : this(id)
            {
                this.Name = name;
            }

            public void Promote()
            {
                Orders = new List<Order>();

                // ...
            }
        }
    }
}
