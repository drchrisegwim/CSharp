using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Fields
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer(1);
            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());

            //If for accidental discord someone calls the promote method of the customer class the reinitializes the order field, all previous data in list of order items will be lost as shown below

            customer.Promote();

            Console.WriteLine(customer.Orders.Count);


            Console.ReadLine();
        }
    }
}
