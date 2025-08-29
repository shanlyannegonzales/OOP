using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gonzales_COConstructorUserInput
{
    internal class Program
    {
        //Name:Gonzales,Shanly Anne
        //Section:IT306
        //Exercise title: Use a parameterized constructor to set arguments for the class fields.
        static void Main(string[] args)
        {
        Main:
            Console.Clear();
            //Ask the user to input
            Console.WriteLine("This program will ask about your favorite cellphone. \n\n");
            Console.Write("Enter brand name: \t");
            string aBrand = Console.ReadLine();

            Console.Write("Enter color:      \t");
            string aColor = Console.ReadLine();

            Console.Write("Enter storage:   \t");
            string aStorage = Console.ReadLine();

            //Instantiate a class object
            Cellphone cellphone1 = new Cellphone(aBrand, aColor, aStorage);

            //Call the method to display
            cellphone1.DisplayCellphoneDetails();

            //Input another book ddetails
            Console.Write("\nDo you want to try again (y/n)? ");
            char ans = Convert.ToChar(Console.ReadLine());
            if (ans == 'y')
            {
                goto Main;
            }
            else if (ans == 'n')
            {
                return;
            }
        }
    }
}
