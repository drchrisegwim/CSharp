using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Classses
{
    public class Person
    {
        //Person class's field
        public string Name;

        //Person class's Method by name Instroduction
        public void Introduction(string to)
        {

            Console.WriteLine("Hi {0}, I am {1}", to , Name);
        }


        //Creating a Person's object from a string 
        public static Person Parse(string str)
        {
            Person person = new Person();
            person.Name = str;

            return person;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            /* 
            Person person = new Person();

            person.Name = "Christian";
            person.Introduction("Glory");

            */

            var person = Person.Parse("eGlory");
            person.Introduction("Emeksense");

        }
    }
}
