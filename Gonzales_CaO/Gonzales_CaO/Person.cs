using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gonzales_CaO
{
    internal class Person
    {
        //Class members
        public string name;
        public int age;
        public string gender;

        //Method Display
        public void Greet()
        {
            Console.WriteLine("Annyeohaseyo! My name is " + name + " and I am " + age + " years of age, and I'm a " + gender + ".");
        }
    }
        
}
