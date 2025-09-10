using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gonzales_InheritanceUserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            // Show available stock
            Console.WriteLine("\n--- These are the bags we currently have in stock --- \n\nPlease choose one:");
            Console.WriteLine("1. Backpack");
            Console.WriteLine("2. Handbag");
            Console.Write("Enter choice (1-2): ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                // Backpack
                Console.WriteLine("\nPlease enter the following details for the Backpack:");
                Console.Write("Enter Brand: ");
                string brand = Console.ReadLine();
                Console.Write("Enter Color: ");
                string color = Console.ReadLine();
                Console.Write("Enter Capacity (liters): ");
                int capacity = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Compartments: ");
                int compartments = Convert.ToInt32(Console.ReadLine());

                Backpack backpack = new Backpack(brand, color, capacity, compartments);
                Console.WriteLine("\n--- Backpack Info ---");
                backpack.ShowBackpack();
            }
            else if (choice == 2)
            {
                // Handbag
                Console.WriteLine("\nPlease enter the following details for the Handbag:");
                Console.Write("Enter Brand: ");
                string brand = Console.ReadLine();
                Console.Write("Enter Color: ");
                string color = Console.ReadLine();
                Console.Write("Enter Material: ");
                string material = Console.ReadLine();
                Console.Write("Enter Handle Length (cm): ");
                int handleLength = Convert.ToInt32(Console.ReadLine());

                Handbag handbag = new Handbag(brand, color, material, handleLength);
                Console.WriteLine("\n--- Handbag Info ---");
                handbag.ShowHandbag();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid choice."); // Error Handling
                
            }

            // This makes the program wait before closing
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
