using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Method overriding is about modifying the implementation of an inherited method.
namespace _12_MethodOverriding
{
    partial class Program
    {
        public class Circle : Shape
        {
            //This override keyword was neccessary here only because the draw method from the parent class has virtual keyword decorated on it.
            public override void Draw()
            {
                Console.WriteLine("Draw a circle");
                
            }
        }

        public class Rentangle: Shape
        {
            public override void Draw()
            {
                Console.WriteLine("Draw a Rentangle");
            }
        }
        static void Main(string[] args)
        {
            List<Shape> shape = new List<Shape>();
            shape.Add(new Circle());
            shape.Add(new Rentangle());

            Canvas  canvas = new Canvas();
            canvas.DrawShapes(shape);

            Console.ReadLine();
        }
    }


}
