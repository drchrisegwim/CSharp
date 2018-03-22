using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_BoxingAndUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            //Value types (eg bytes, int, float, bool) are stored on the stack while reference types (eg. Classes, Object, Array, string) are stored on the heap.

            //So boxing is the process of converting a value type instance to an object reference.

            int number = 10;
            object obj = number;

                   //or
            object anotherObject = 10;

        }
    }
}
