using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gonzales_InheritanceWithUserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            // Menu for the user to choose a device type
            Console.WriteLine("\n \tIYChoose a Gadget type:");
            Console.WriteLine("\n\t1. Smartphone");
            Console.WriteLine("\t2. Laptop");
            Console.WriteLine("\t3. Tablet");
            Console.Write("\tEnter choice (1-3): ");
            int choice = Convert.ToInt32(Console.ReadLine());

            // Handle choice
            if (choice == 1)
            {
                // Smartphone input
                Console.Write("\n\tEnter Brand: ");
                string brand = Console.ReadLine();
                Console.Write("\tEnter Model: ");
                string model = Console.ReadLine();
                Console.Write("\tEnter Operating System: ");
                string os = Console.ReadLine();

                // Create and display smartphone
                Smartphone phone = new Smartphone(brand, model, os);
                Console.WriteLine("\n\t--- Smartphone Info ---");
                phone.ShowSmartphone();
            }
            else if (choice == 2)
            {
                // Laptop input
                Console.Write("\n\tEnter Brand: ");
                string brand = Console.ReadLine();
                Console.Write("\tEnter Model: ");
                string model = Console.ReadLine();
                Console.Write("\tEnter Processor: ");
                string proc = Console.ReadLine();

                // Create and display laptop
                Laptop laptop = new Laptop(brand, model, proc);
                Console.WriteLine("\n\t--- Laptop Info ---");
                laptop.ShowLaptop();
            }
            else if (choice == 3)
            {
                // Tablet input
                Console.Write("\n\tEnter Brand: ");
                string brand = Console.ReadLine();
                Console.Write("\tEnter Model: ");
                string model = Console.ReadLine();
                Console.Write("\tDoes it support stylus? (yes/no): ");
                string stylusInput = Console.ReadLine().ToLower();

                bool hasStylus = stylusInput == "yes";  // Convert input to boolean

                // Create and display tablet
                Tablet tablet = new Tablet(brand, model, hasStylus);
                Console.WriteLine("\n\t--- Tablet Info ---");
                tablet.ShowTablet();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red; // Change text color to red
                Console.WriteLine("\tInvalid choice."); // Error handling
            }

            Console.ReadKey();
        }
    }
}
