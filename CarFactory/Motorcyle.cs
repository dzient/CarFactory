using System;
//
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
    public class Motorcycle : IVehicle, ICallable
    {

        public string Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Wheels { get; set; }
        private bool HasSideCart { get; set; }
        // Define accessors + mutators for HasSideCart:
        public void SetHasSide(bool val)
        {
            HasSideCart = val;
        }
        public bool GetHasSideCart()
        {
            return HasSideCart;
        }
        // Motorcycle
        // Constructor for Motorcyle class that takes parameters
        public Motorcycle(string year, string make, string model, int wheels, bool hasSideCart)
        {
            Year = year;
            Make = make;
            Model = model;
            Wheels = wheels;
            HasSideCart = hasSideCart;
        }
        // Motorcycle
        // Constructor for Motorcyle class w/no parameters
        // All properties will be set to reasonable defaults
        public Motorcycle()
        {
            Year = "1980";
            Make = "Kawasaki";
            Model = "Ninja";
            Wheels = 2;
            HasSideCart = true;
        }
        // Build
        // Simple method for building a motorcycle
        // PARAMS: None
        // RETURNS: Nothing
        public void Build()
        {
            Console.WriteLine("Building a motorcycle!");
        }
        // Drive
        // Simple method for driving a motorcycle
        // PARAMS: None
        // RETURNS: Nothing
        public void Drive()
        {
            Console.WriteLine("Driving a motorcycle!");
        }
    }
}