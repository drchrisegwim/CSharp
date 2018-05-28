using System;

namespace _5_AccessModifiers
{
    partial class Program
    {
        // Make sure your classes are always in a valid state....
        public class Person
        {
            // So hence fort note that fields ought be only visible on its own class ONLy. Also note that by conventions felds should be named starting with underscore and then camel case naming convention as shown below:

            private DateTime _dateOfBirth;

            // And then fieds are initilized and presnted by the methods below ( AKA properties) to other classes.

            public void SetDateOfBirth(DateTime dateOfBirth)
            {
                this._dateOfBirth = dateOfBirth;
            }


            public DateTime GetDateOfBirth()
            {
                return _dateOfBirth;
            }

            //The above methods (properties) later became  written like this in C# as shown below

            public DateTime DateOfBirth
            {
                get { return _dateOfBirth; }
                set { _dateOfBirth = value; }
            }

           

            //Then currently properites now are usually now written as auto-implementend properties as shown below:
            // So when the c# compiler see the code below it creates a field for it.

            public DateTime DateOfBirthAgain { get; set; }  // Added Again to the name just to deferenciate it from the above dateOfBirth


            //I added this to learn how to write the un auto implemented version of properties.
            public DateTime Emeksense
            {
                get
                {
                    return _dateOfBirth;
                }
                set
                {
                    _dateOfBirth = value ;
                }
            }


            //NB Some properties ought not to be auto - implemented eg Age, Why because we need to logic to get and set their values as shown below:

            public int Age
            {
                get
                {
                    var timeStamp = DateTime.Today - _dateOfBirth;
                    var years = timeStamp.Days / 365;

                    return years;

                }
            }

        }
    }
}
