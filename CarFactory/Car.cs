using System;

/// <summary>
/// Summary description for Class1
/// </summary>
/// 
//
// Name: David Zientara
// Date: 7-21-2022
// Comments: An exercise in using factory patterns
// Added methods per the instructions
//-----------------------------------------------------------------
namespace FactoryPattern
{
    public class Car : IVehicle, ICallable
    {

        public string Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Wheels { get; set; }
        private bool HasTrunk { get; set; }
        // Define accessors + mutators for HasTrunk:
        public void SetHasTrunk(bool val)
        {
            HasTrunk = val;
        }
        public bool GetHasTrunk()
        {
            return HasTrunk;
        }
        // Car
        // Constructor for Car class with parameters
        public Car(string year, string make, string model, int wheels, bool hasTrunk)
        {
            Year = year;
            Make = make;
            Model = model;
            Wheels = wheels;
            HasTrunk = hasTrunk;
        }
        // Car
        // Constructor for Car class w/o parameters
        public Car()
        {
            Year = "1970";
            Make = "Plymouth";
            Model = "Valiant";
            Wheels = 4;
            HasTrunk = true;
        }
        // Build
        // Simple method for building a car
        // PARAMS: None
        // RETURNS: Nothing
        public void Build()
        {
            Console.WriteLine("Building a car!");
        }
        // Drive
        // Simple method for driving a car
        // PARAMS: None
        // RETURNS: Nothing
        public void Drive()
        {
            Console.WriteLine("Driving a car!");
        }
    }
}