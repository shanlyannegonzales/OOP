using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gonzales_COConstructorUserInput
{

    //Name:Gonzales,Shanly Anne
    //Section:IT306
    //Exercise title:  Use a parameterized constructor to set arguments for the class fields.
    internal class Cellphone
    {
        //Attributes
        public string brand;
        public string color;
        public string storage;

        public Cellphone(string aBrand, string aColor, string aStorage)  //Parameterized Constructor
        {
            brand = aBrand;
            color = aColor;
            storage = aStorage;
        }

        //Method to Dsiplay the Cellphone Details
        public void DisplayCellphoneDetails()
        {
            Console.Clear();
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("-------- Here are the Cellphone Details --------");
            Console.WriteLine("Cellphone Brand: " + brand);
            Console.WriteLine("Cellphone Color: " + color);
        }
    }
}
