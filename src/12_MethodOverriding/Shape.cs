namespace _12_MethodOverriding
{
    partial class Program
    {
        public class Shape
        {
            public int Width { get; set; }
            public int Height { get; set; }
            public Postion Postion { get; set; }
          //  public ShapeType Type { get; set; }

            // The virtual key word is required so that any class that inherits from the shape class can decide to change the implementation of its own Draw method (by adding override on its menthod declaration) or just use the default one from the base shape class
            public virtual void Draw()
            {

            }
        }
    }

    
}
