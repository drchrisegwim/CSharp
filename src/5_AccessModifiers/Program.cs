using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_AccessModifiers
{
    public class GoldCustomer : Customer
    {
        public void OfferVoucher()
        {
            this.CalculateRating(true,1);  //This is accessible only because it declared as protected in the customer class.
        }
    }
    partial class Program
    {

        static void Main(string[] args)
        {
            Person person = new Person();
            person.SetDateOfBirth(new DateTime(1989,09,15));
            Console.WriteLine(person.GetDateOfBirth());
            Console.WriteLine(person.Age);


            // So
            Customer customer = new Customer();
            //customer.CalculateRating();

            Console.ReadLine();
        }
    }
}
