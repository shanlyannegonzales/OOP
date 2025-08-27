using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gonzales_PropertiesAndEncapsulation
{
    internal class Bag
    {
        //Declare the properties of the Bag class
        private string brand;
        private string color;
        private int capacity;

        //Set the properties for the Bag class fields
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }
        //Method to display bag information
        public void DisplayBagInfo()
        {
            Console.WriteLine("\t Here are the Bag Details");
            Console.WriteLine($"\n \t Brand: {Brand}\n \t Color: {Color}\n \t Capacity: {Capacity}\n");
        }
    }
}
