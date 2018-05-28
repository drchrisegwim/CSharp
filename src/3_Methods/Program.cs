using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Calculator calculator = new Calculator();
            calculator.Add(new []{2,5});
            calculator.Add(2,4,6,20);
            */

            Point point = new Point(10, 32);
            point.Move(new Point(34, 55));
            Console.WriteLine("The location is at {0}, and {1}", point.X, point.Y);

            Calculator calculator = new Calculator();
            Console.WriteLine(calculator.Add(2, 3, 5));

            var number = 0;
            var result = int.TryParse("eme", out number);
            if (result)
                Console.WriteLine(number);

            Console.ReadLine();
        }
    }
}
