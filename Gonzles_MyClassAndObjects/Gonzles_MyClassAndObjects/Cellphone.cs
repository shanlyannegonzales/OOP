using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gonzles_MyClassAndObjects
{
    //Name: Gonzales, Shanly Anne
    //Section: IT306
    //Exercise title: Create your own class at least 3 attributes/fields and 2 class object
    internal class Cellphone
    {
        //Attributes
        public string brand;
        public string color;
        public string storage;

        //Method Display
        public void DisplayInfo()
        {
            Console.WriteLine("\n \t Brand: " + brand);
            Console.WriteLine("\n \t Color: " + color);
            Console.WriteLine("\n \t Storage: " + storage);
        }
    }
}
