using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Constructor
{
    public class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer(1,"cegwim");

            Order order = new Order();
            customer.Orders.Add(order);
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
        }
    }
}
