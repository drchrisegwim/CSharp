using System;

namespace _13_AbstarctClasses
{

    public abstract class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public abstract void Draw();

        public void Copy()
        {
            Console.WriteLine("Copied code to clipboard!!!");
        }
    }

}
