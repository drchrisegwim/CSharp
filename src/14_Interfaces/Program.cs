using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderProcessor orderProcessor = new OrderProcessor();

            Order order = new Order{ DatePlaced = DateTime.Now, TotalPrice = 100f};

            orderProcessor.Process(order);
        }
    }
}
