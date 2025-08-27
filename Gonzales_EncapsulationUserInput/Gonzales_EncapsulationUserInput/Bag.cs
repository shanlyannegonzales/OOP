using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gonzales_EncapsulationUserInput
{
    internal class Bag
    {
        // Use auto-properties (shorthand encapsulation)
        public string Brand { get; set; }
        public string Color { get; set; }
        public int Capacity { get; set; }

        // Method to display bag details
        public void DisplayBagInfo()
        {
            Console.WriteLine("\n\tHere are the Bag Details:");
            Console.WriteLine($"\tBrand: {Brand}");
            Console.WriteLine($"\tColor: {Color}");
            Console.WriteLine($"\tCapacity: {Capacity} liters");
        }
    }
}
