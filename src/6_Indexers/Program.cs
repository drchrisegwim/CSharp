using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Indexers
{
    partial class Program
    {


        static void Main(string[] args)
        {
            HttpCookie cookie = new HttpCookie();
            cookie["name"] = "Christian Egwim";

            Console.WriteLine(cookie["name"]);

            Console.ReadLine();
        }
    }
}
