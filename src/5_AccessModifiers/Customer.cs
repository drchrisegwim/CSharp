using System;

namespace _5_AccessModifiers
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            var result = CalculateRating(excludeorders: true);
            if (result == 0)
                Console.WriteLine("You are promoted to level one!!!");
            else
                Console.WriteLine("You are promoted to level two!!!");
        }

        //The method below ought not to be decalred public cos it all about business logic implementation details. So that a caller of the customer class will not accidentally use it as done on the progam class.

        //Change the access modifier to public to undertand the above comment


        private int CalculateRating(bool excludeorders)
        {
            return 0;
        }

        // Protected is accessible only form the class and its derived classes.
        protected int CalculateRating(bool excludeorders, int i)
        {
            return 0;
        }

        //Interanl is usally used for classes ONLY and it accessble only from the same assembly.

    }
}