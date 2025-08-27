using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gonzales_EncapsulationUserInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Inform the user what kind of inputs the program will ask for, with example values
            Console.WriteLine("\t Program will ask you to enter bag details.");
            Console.WriteLine("For example: Brand = Hermes, Color = Pink, Capacity = 5 liters.\n");
            // Create variables to hold user input
            Console.Write("\tEnter Bag Brand: ");
            string brandInput = Console.ReadLine();

            Console.Write("\tEnter Bag Color: ");
            string colorInput = Console.ReadLine();

            Console.Write("\tEnter Bag Capacity (in liters): ");
            int capacityInput;
            while (!int.TryParse(Console.ReadLine(), out capacityInput) || capacityInput < 0)
            {
                Console.WriteLine(" Please enter a valid positive integer for capacity: ");
            }

            // Instantiate the Bag class and initialize with user inputs
            Bag myBag = new Bag
            {
                Brand = brandInput,
                Color = colorInput,
                Capacity = capacityInput
            };

            // Display the Bag Information
            myBag.DisplayBagInfo();

            Console.ReadKey();
        }
    }
}
