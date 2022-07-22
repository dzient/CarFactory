using System;

/// <summary>
/// Summary description for Class1
/// </summary>
//
// Name: David Zientara
// Date: 7-21-2022
// Comments: An exercise in using factory patterns
// Added methods per the instructions
//-----------------------------------------------------------------
namespace FactoryPattern
{
    class SUV : IVehicle, ICallable
    {
        public string Name { get; set; }
        public string Industry { get; set; }
        public string Logo { get; set; }
        public string Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Wheels { get; set; }
        // Define accessors + mutators for
        // MinCargoHoldSize + MaxCargoHoldSize:
        private double MinCargoHoldSize { get; set; }
        private double MaxCargoHoldSize { get; set; }

        public void SetMinCargoHoldSize(double val)
        {
            MinCargoHoldSize = val;
        }
        public void SetMaxCargoHoldSize(double val)
        {
            MaxCargoHoldSize = val;
        }
        public double GetMinCargoHoldSize()
        {
            return MinCargoHoldSize;
        }
        public double GetMaxCargoHoldSize()
        {
            return MaxCargoHoldSize;
        }
        // SUV 
        // Constructor for SUV with parameters
        public SUV(string name, string industry, string logo, string year, string make, string model, int wheels, double minCargoHoldSize, double maxCargoHoldSize)
        {
            Name = name;
            Industry = industry;
            Logo = logo;
            Year = year;
            Make = make;
            Model = model;
            Wheels = wheels;
            MinCargoHoldSize = minCargoHoldSize;
            MaxCargoHoldSize = maxCargoHoldSize;
        }
        // SUV 
        // Constructor for SUV w/o parameters
        public SUV()
        {
            Name = "Ford Explorer";
            Industry = "Manufacturing";
            Logo = "Ford";
            Year = "1991";
            Make = "Ford";
            Model = "Explorer";
            Wheels = 4;
            MinCargoHoldSize = 40.7;
            MaxCargoHoldSize = 83;
        }
        // Build
        // Simple method for building an SUV
        // PARAMS: None
        // RETURNS: Nothing
        public void Build()
        {
            Console.WriteLine("Building an SUV!");
        }
        // Drive
        // Simple method for driving an SUV
        // PARAMS: None
        // RETURNS: Nothing
        public void Drive()
        {
            Console.WriteLine("Driving an SUV!");
        }
    }
}