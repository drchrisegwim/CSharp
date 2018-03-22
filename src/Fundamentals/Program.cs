using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
   public class Program
    {
        static void Main(string[] args)
        {
            //Declaring a contant in C#
            const float pi = 3.142f;

            const decimal avg = 4.12m;

            //Using a reserved keyword in csharp must then be escapped with the @ symbol
            int @int = 3;


            checked
            {
                byte number = 250;
                //number = number + 1;
            }

            var cr = 'e';

            // Explicit type convation (AKA Casting)

            int b = 1;
            byte d = (byte)b;

            //Incompatible types

            var num = "12345";

            // You cant be able to do the next line below because of type incompatiblity
            //int i = (int) number;   

            int i = Convert.ToInt32(num);


            Console.WriteLine("Hello Emeksense!!!");
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);
            Console.WriteLine(d);
            Console.WriteLine(i);
        }
    }
}
