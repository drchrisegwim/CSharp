using System;

namespace _3_Methods
{
    public class Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(Point newLocation)
        {
            /*
            this.X = newLocation.X;
            this.Y = newLocation.Y;
            */

            //The above code can be better written as this below to avoid repeatition of concept.

            // For defensive programming
            if(newLocation == null)
                throw new ArgumentException("newLocation");
            Move(newLocation.X, newLocation.Y);
        }
    }
}