using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Collections.Specialized.BitVector32;

namespace Gonzales_SimpleInheritance
{
    //Name: Gonzales, Shanly Anne
    //Section: IT306
    //Exercise Title: Use these classes:  Student class (Base class); RegularStudent class (Derived class); IrregularStudent class (Derived class)
    class Student //Base class
    {
        //Prooperties for the Student Class
        public string Name { get; set; }
        public string Program { get; set; }

        //Method to display student information
        public void StudentBasicInfo()
        {
            Console.WriteLine("\n ----- Student Information -----\n");
            Console.WriteLine($"Name: {Name}, \nProgram: {Program}");
        }
    }

    class Regular : Student //Derived class
    {
        //Additional property for the Regular class
        public string Section { get; set; }

        //Method to display regular information
        public void SectionEnrolled()
        {
            Console.WriteLine($"Section: {Section}");
        }
    }
    class Irregular : Student //Another derived class
    {
        //Additional property for the Irregular class
        public string UnitsEnrolled { get; set; }

        //Method to display Irregular information
        public void EnrolledSemUnits()
        {
            Console.WriteLine($"UnitsEnrolled: {UnitsEnrolled}");
        }
    }
}




//Use these classes:  Student class (Base class); RegularStudent class (Derived class); IrregularStudent class (Derived class)
//Student class properties : Name and Program
//RegularStudent property: Section
//IrregularStudent property: UnitsEnrolled
//Student class method : BasicInfo()
//RegularStudent method: SectionEnrolled()
//IrregularStudent method: EnrolledSemUnits()
//In the program class, instantiate an object for each derived class, then display the student information for both objects, which includes the Name and Program.

//Name: Gonzales, Shanly Anne
//Section: IT306
//Exercise Title: Use these classes:  Student class (Base class); RegularStudent class (Derived class); IrregularStudent class (Derived class)