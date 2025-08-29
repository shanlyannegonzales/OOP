using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gonzales_RepetitionStructure
{
    internal class Program
    {
        //NAME: Gonzales,Shannly Anne
        //SECTION: IT306
        //PROBLEM:  Use a for loop structure to print 10 numbers, and print also the sum of all the numbers.
        static void Main(string[] args)
        {
            //THIS PROGRAM WILL PRINT THE NUMBER FROM 1 TO 10
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\t    Print number 1 to 10 and calculate their total sum");

            int sum = 0;

            for (int s = 1; s <= 10; s++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n \t    Number:\t " + s);
                sum += s;
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n  \t    The total sum of number from 1 to 10 is:\t " + sum);

            Console.WriteLine("\n  \t    Press any key to exit.");
            Console.ReadKey();

        }
    }
}
