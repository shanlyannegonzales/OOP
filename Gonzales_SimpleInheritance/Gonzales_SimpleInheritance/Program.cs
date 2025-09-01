using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gonzales_SimpleInheritance
{
    internal class Program
    {
        //Name: Gonzales, Shanly Anne
        //Section: IT306
        //Exercise Title: Use these classes:  Student class (Base class); RegularStudent class (Derived class); IrregularStudent class (Derived class)
        static void Main(string[] args)
        {
            //Create an instance of the Student class
            Student mystudent = new Student
            {
                Name = "Darren Paul Macuto",
                Program = "BSIT"
            };
            mystudent.StudentBasicInfo(); //Call method to display student info

            //Create an instance of the Regular student
            Regular myRegular = new Regular
            {
                Name = "Shanly Anne Gonzales",
                Program = "BSIT",
                Section = "IT306"
            };
            myRegular.StudentBasicInfo(); //Call inherited method to display Student info
            myRegular.SectionEnrolled(); //Call inherited method to display Regular info

            //Create an instance of the Irregular class
            Irregular myIrregular = new Irregular
            {
                Name = " Ryan Salvo",
                Program = "BSHM",
                UnitsEnrolled = "Irregular"
            };
            myIrregular.StudentBasicInfo(); //Call inherited method to display Student info
            myIrregular.EnrolledSemUnits();  //Call inherited method to display Irregular info

            //Wait for user input before closing
            Console.ReadKey();
        }
    }
}





          