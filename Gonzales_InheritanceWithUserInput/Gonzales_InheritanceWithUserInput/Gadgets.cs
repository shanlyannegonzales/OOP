using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gonzales_InheritanceWithUserInput
{
    class Gadgets
    {
        // Fields
        public string brand;
        public string model;

        // Constructor
        public Gadgets(string gadgetBrand, string gadgetModel)
        {
            brand = gadgetBrand;
            model = gadgetModel;
        }

        // Method
        public void BasicInfo()
        {
            Console.WriteLine($"\tBrand: {brand}, \n\tModel: {model}");
        }
    }

    class Smartphone : Gadgets // Derived class
    {
        // Field
        public string OperatingSystem;

        // Constructor
        public Smartphone(string gadgetBrand, string gadgetModel, string os)
            : base(gadgetBrand, gadgetModel)
        {
            OperatingSystem = os;
        }

        // Method to Display Gadgets Info
        public void ShowSmartphone()
        {
            BasicInfo();
            Console.WriteLine($"\tOperating System: {OperatingSystem}");
        }
    }

    class Laptop : Gadgets // Derived class
    {
        // Field
        public string Processor;

        // Constructor
        public Laptop(string gadgetBrand, string gadgetModel, string processor)
            : base(gadgetBrand, gadgetModel)
        {
            Processor = processor;
        }

        // Method to Display Gagdets Info
        public void ShowLaptop()
        {
            BasicInfo();
            Console.WriteLine($"\tProcessor: {Processor}");
        }
    }

    class Tablet : Gadgets // Derived class
    {
        // Field
        public bool HasStylus;

        // Constructor
        public Tablet(string gadgetBrand, string gadgetModel, bool stylus)
            : base(gadgetBrand, gadgetModel)
        {
            HasStylus = stylus;
        }

        // Method to Display Gadgets Info
        public void ShowTablet()
        {
            BasicInfo();
            Console.WriteLine($"\tStylus Support: {(HasStylus ? "Yes" : "No")}");
        }
    }
}
