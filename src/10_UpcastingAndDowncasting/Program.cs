using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_UpcastingAndDowncasting
{
    class Program
    {
        static void Main(string[] args)
        {
            Text text = new Text();

            //The code below is upcasting ie converting a  derived class to its base class.
            Shape shape = text;
            text.Width = 250;
            shape.Width = 50;

            Console.WriteLine(text.Width);

            // Real world senario of up casting is seen in streamReader class eg
            StreamReader streamReader = new StreamReader(new MemoryStream());  // here memorystream has been upcasted to streamreader.

            // Another Good example is the ArrayList class that accepts any kind of object as an input parament.

            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("Emeksense");
            arrayList.Add(new int());

            //The above ArrayList is not too cool as there can be issues when trying to use the list cos it contains data of different type.

            // So the need to use a generic list as shown below.

            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2323);
            //....

            //Now to down casting....
            Shape myShape = new Text();
            Text myText = (Text) myShape;

            Console.ReadLine();
        }
    }
}
