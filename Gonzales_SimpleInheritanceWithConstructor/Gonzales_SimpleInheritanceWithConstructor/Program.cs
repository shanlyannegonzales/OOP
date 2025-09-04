using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gonzales_SimpleInheritanceWithConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ----These are the student details---- ");
            Regular regular = new Regular("Shanly Anne Gonzales", "BSIT", "IT306"); // Create Student Info
            regular.SectionEnrolled();  // Display Section Info

            Irregular irregular = new Irregular("Darren Paul Macuto", "HM102", "28");
            irregular.EnrolledSemUnits();  //Display Units Info

            Console.ReadKey();
        }
    }
}
