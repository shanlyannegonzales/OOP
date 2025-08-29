using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gonzales__ControlFlowStructures
{
    internal class Program
    {
        //Gonzales, Shanly Anne
        //IT306P
        //PROBLEM:  Check if a number entered by the user is between a certain range of numbers (inclusive).
        static void Main(string[] args)
        {
            Console.WriteLine("\t           Welcome to the Range Checker!");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n This program will check if a number you enter is within a specified range.");


            Console.Write("Please Enter a Number");
            string input = Console.ReadLine();

            int num;
            bool isNum = int.TryParse(input, out num);

            if (!isNum)
            {
                Console.WriteLine("Invalid Input");
            }
            else
            {
                if (num >= 10 && num <= 20)
                {
                    Console.WriteLine("The number " + num + " is with in the range of 10-20.");
                }
                else
                {
                    Console.WriteLine("The number " + num + "is Not within the range of 10-20.");
                }
                Console.WriteLine("Thank you for using our Program! Press any key to exit.");
            }
        }
    }
}
