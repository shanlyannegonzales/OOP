using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gonzales_InheritanceUserInput
{
    //Name: Gonzales, Shanly Anne
    //Section: IT306
    //Exercise Title: Inheritance User Input
    class Bag // Base class
    {
        public string Brand;
        public string Color;

        public Bag(string brand, string color) // Constructor
        {
            Brand = brand;
            Color = color;
        }

        public void ShowBasicInfo()
        {
            Console.WriteLine($"\nBrand: {Brand}");
            Console.WriteLine($"Color: {Color}");
        }
    }

    // Derived class 1 (child)
    class Backpack : Bag
    {
        public int Capacity;
        public int Compartments;

        public Backpack(string brand, string color, int capacity, int compartments) : base(brand, color) // Calls base class constructor
        {
            Capacity = capacity;
            Compartments = compartments;
        }

        public void ShowBackpack()
        {
            ShowBasicInfo();
            Console.WriteLine($"Capacity: {Capacity} liters");
            Console.WriteLine($"Compartments: {Compartments}");
        }
    }

    // Derived class 2 (child)
    class Handbag : Bag
    {
        public string Material;
        public int HandleLength;

        public Handbag(string brand, string color, string material, int handleLength) : base(brand, color)  // Calls base class constructor
        {
            Material = material;
            HandleLength = handleLength;
        }

        public void ShowHandbag()
        {
            ShowBasicInfo();
            Console.WriteLine($"Material: {Material}");
            Console.WriteLine($"Handle Length: {HandleLength} cm");
        }
    }
}
