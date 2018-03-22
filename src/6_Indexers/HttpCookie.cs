using System.Collections.Generic;

namespace _6_Indexers
{
    partial class Program
    {
        public class HttpCookie
        {
            //Now the difference between a list and a dictionary is that list uses index to search while dictionary uses key.
            private readonly Dictionary<string, string> _dictionary;

            //As usual when you create an object of another class in a class, you need to initialize it in the constructor to avoid null reference exception as shown below:

            public HttpCookie()
            {
                _dictionary = new Dictionary<string, string>();
            }


            //Now to declare an index note the following:
            //1. Indexes are just like normal properties with get and set in it.
            //2. However, Indexes dont have name, they use the this keyword as their name as shown below

            public string this[string key]
            {
                get { return _dictionary[key]; }
                set { _dictionary[key] = value; }
            }


        }
    }
}
