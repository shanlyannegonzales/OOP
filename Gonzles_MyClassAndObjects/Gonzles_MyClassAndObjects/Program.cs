using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gonzles_MyClassAndObjects
{
    internal class Program
    {
        //Name: Gonzales, Shanly Anne
        //Section: IT306
        //Exercise title: Create your own class at least 3 attributes/fields and 2 class object
        static void Main(string[] args)
        {
            //Instantiation of an object
            Cellphone cellphone1 = new Cellphone();
            Cellphone cellphone2 = new Cellphone();

            //Instantiation of fields
            cellphone1.brand = "\t Samsung";
            cellphone1.color = "\t Ocean Blue";
            cellphone1.storage = "\t 128GB";

            cellphone2.brand = "\t Oppo";
            cellphone2.color = "\t Black";
            cellphone2.storage = "\t 256GB";

            //Call the method to display info
            Console.WriteLine("\n\t Cellphone 1 Details");
            cellphone1.DisplayInfo();

            Console.WriteLine("\n\t Cellphone 2 Details");
            cellphone2.DisplayInfo();

            Console.ReadKey();
        }
    }
}
