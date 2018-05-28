using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_AbstarctClasses
{
    partial class Program
    {

        /*
         * Abstract Modifier indicates that a class or a member is missing implementation.
         * So abstract classes are inherently virtual and can provide polymophic behavior.
           Also if a member is declared as abstract, the containing class needs to be declared as abstract too.
           Derived classes must implement all abstract members in the base abstract class.
           N/B Abstarct classes cannot be instantiated o.
           
           So why do we now need Abstract classes? Ans. When you want to provide some common bbehaviour, while forcing other developers to follow your design.
           
         */
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            circle.Draw();

            Rectangle rectangle = new Rectangle();
            rectangle.Draw();

            Console.ReadLine();
        }




        /*
         *
         *Sealed classes is the opposite of abstarct classes...
           Meaning it prevents derivation of classes or overriding of method.
           SO why do we need seeled classes? Ans. Sealed classes are slightly faster because of some run-time optimizations.
           
           
           Its not where I work but who I am. Am 
         *
         */
    }
}
