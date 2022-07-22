using System;
//
// Name: David Zientara
// Date: 7-21-2022
// Comments: An exercise in using factory patterns
// Added methods per the instructions
//-----------------------------------------------------------------
/// <summary>
/// Summary description for VehicleFactory
/// </summary>
/// 
// Create a Vehicle Factory class that returns an ICallable-derived object
namespace FactoryPattern
{
    internal static class VehicleFactory
    {
        // GetVehicle
        // Function takes a string indicating what vehicle to 
        // create and returns the object
        // PARAMS: vehicleType (string)
        // RETURNS: ICallable-derived object
        public static ICallable GetVehicle(string vehicleType)
        {
            switch (vehicleType.ToLower())
            {
                case "car":
                    return new Car();
                case "motorcycle":
                    return new Motorcycle();
                case "truck":
                    return new Truck();
                case "suv":
                    return new SUV();
                default:
                    return new Car();
            }
        }
    }
}