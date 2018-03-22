using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Inheritance
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Text text = new Text();
            text.Width = 100;
            text.Copy();

            Console.ReadLine();
        }
    }
}
