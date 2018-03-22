using System;

namespace _7_Inheritance
{
    partial class Program
    {
        public class PresentationObject
        {
            public int Width { get; set; }
            public int Height { get; set; }

            public void Copy()
            {
                Console.WriteLine("Copied to clipboard");
            }

            public void Duplicate()
            {
                Console.WriteLine("Object was duplicated");
            }
        }
    }
}
