using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gonzales_SimpleInheritanceWithConstructor
{
    class Student // Base Class
    {
        //Fields
        public string name;
        public string program;

        public Student(string studentName, string studentProgram)
        {
            name = studentName;
            program = studentProgram;
        }

        // Constructor
        public void BasicInfo()
        {
            Console.WriteLine($"\nName: {name}, \nProgram: {program}");
        }
    }

    class Regular : Student // Derived class
    {
        // Field
        public string Section;

        // Constructor
        public Regular(string studentName, string studentProgram, string studentSection) : base(studentName, studentProgram)
        {
            Section = studentSection;
        }

        // Method to Display Section Info
        public void SectionEnrolled()
        {
            BasicInfo(); // Call base class method
            Console.WriteLine($"Section: {Section}");
        }
    }

    class Irregular : Student // Derived class
    {
        public string UnitsEnrolled;

        // Constructor
        public Irregular(string studentName, string studentProgram, string studentUnitsEnrolled) : base(studentName, studentProgram)
        {
            UnitsEnrolled = studentUnitsEnrolled;
        }

        // Method to Display Units Info
        public void EnrolledSemUnits()
        {
            BasicInfo();
            Console.WriteLine($"UnitsEnrolled: {UnitsEnrolled}");
        }
    }
}
