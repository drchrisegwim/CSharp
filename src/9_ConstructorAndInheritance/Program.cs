using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_ConstructorAndInheritance
{
    class Program
    {
        //The base key word is a way to access the base class from a current class deriving from such class. It simply like a method call.And that method is simply the contructor of the base class, as the default constructor of base classes are NOT accessible by default from the derived class.
        static void Main(string[] args)
        {
            Car car = new Car("Toyota123");

            Console.ReadLine();
        }
    }
}
