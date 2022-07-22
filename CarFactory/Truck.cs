using System;
// Name: David Zientara
// Date: 7-21-2022
// Comments: An exercise in using factory patterns
// Added methods per the instructions
//-----------------------------------------------------------------
/// <summary>
/// Summary description for Class1
/// </summary>
/// 
namespace FactoryPattern
{
    class Truck : IVehicle, ICallable
    {
        public string Name { get; set; }
        public string Industry { get; set; }
        public string Logo { get; set; }
        public string Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Wheels { get; set; }
        private int MinBedSize { get; set; }
        private int MaxBedSize { get; set; }
        // Define accessors + mutators for
        // MinBedSize + MaxBedSize:
        public void SetMinBedSize(int val)
        {
            MinBedSize = val;
        }
        public void SetMaxBedSize(int val)
        {
            MaxBedSize = val;
        }

        public int GetMinBedSize()
        {
            return MinBedSize;
        }
        public int GetMaxBedSize()
        {
            return MaxBedSize;
        }
        // Truck
        // Constructor for Truck with parameters
        public Truck(string name, string industry, string logo, string year, string make, string model, int wheels, int minBedSize, int maxBedSize)
        {
            Name = name;
            Industry = industry;
            Logo = logo;
            Year = year;
            Make = make;
            Model = model;
            Wheels = wheels;
            MinBedSize = minBedSize;
            MaxBedSize = maxBedSize;
        }
        // Truck
        // Constructor for Truck w/o parameters
        public Truck()
        {
            Name = "Ford";
            Industry = "Manufacturing";
            Logo = "Ford";
            Year = "2000";
            Make = "Ford";
            Model = "F-150";
            Wheels = 4;
            MinBedSize = 66;
            MaxBedSize = 96;
        }
        // Build
        // Simple method for building a truck
        // PARAMS: None
        // RETURNS: Nothing
        public void Build()
        {
            Console.WriteLine("Building a truck!");
        }
        // Drive
        // Simple method for driving a truck
        // PARAMS: None
        // RETURNS: Nothing
        public void Drive()
        {
            Console.WriteLine("Driving a car!");
        }
    }
}