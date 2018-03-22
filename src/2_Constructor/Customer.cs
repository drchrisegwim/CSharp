using System.Collections.Generic;

namespace _2_Constructor
{
    public class Customer
    {
        //declaring members of the class Customer
        public int Id;
        public string Name;

        public List<Order> Orders;


        //Constructor with zero agument
        public Customer()
        {
            //It a rule of thumb to initialize objects member of a class in the default constructor to avoid null reference exception 
            this.Orders = new List<Order>();
        }

        //Custructor with one argument
        public Customer(int id)
         : this() // This is a reference to a default constructor so you dont have to initialize the members in the above constructor
        {
            this.Id = id;
        }

        //constructor with two arguments
        public Customer(int id, string name)
        : this(id) // Same as the above comment.
        {
            this.Id = id;
            this.Name = name;
        }

    }
}