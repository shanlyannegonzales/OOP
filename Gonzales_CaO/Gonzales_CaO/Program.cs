using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gonzales_CaO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person(); //instantiation of an object

            //instantiation of fields
            person1.name = "Shanly Anne";
            person1.age = 19;
            person1.gender = "Female";

            //call the method
            person1.Greet();

            Console.ReadKey();
        }
    }
}
