using System;
using System.Collections.Generic;

namespace _12_MethodOverriding
{
    partial class Program
    {
        public class Canvas
        {
            public void DrawShapes(List<Shape> shapes)
            {
                foreach (var shape in shapes)
                {

                    /*
                    switch (shape.Type)
                    {
                        case ShapeType.Circle:
                            Console.WriteLine("Draw a circle");
                            break;
                        case ShapeType.Rectangle:
                            Console.WriteLine("Draw a rentangle");
                            break;
                    }
                   */

                    shape.Draw();
                }
            }
        }
    }


}
