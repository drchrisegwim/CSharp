using System;

namespace _9_ConstructorAndInheritance
{
    public class Car : Vehicle
    {
        //The base key word is a way to access the base class from a current class deriving from such class. It simply like a method call.And that method is simply the contructor of the base class, as the default constructor of base classes are NOT accessible by default from the derived class.
        public Car(string registrationNumber)
         : base(registrationNumber)
        {
            Console.WriteLine("Car is been Initialized!!!, {0}", registrationNumber);
        }

    }
}