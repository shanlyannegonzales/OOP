using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gonzales_PropertiesAndEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instantiate the Bag class
            Bag myBag = new Bag();

            //Set the properties of the Bag class fields
            myBag.Brand = "Hermes";
            myBag.Color = "Pink";
            myBag.Capacity = 5; // medium-sized Hermès bag capacity in liters

            //Display the Bag Information
            myBag.DisplayBagInfo();

            Console.ReadKey();
        }
    }
}
