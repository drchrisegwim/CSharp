using System;

namespace _13_AbstarctClasses
{
    partial class Program
    {
        public class Rectangle : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("Draw a rectangle.");
            }
        }
    }
}
