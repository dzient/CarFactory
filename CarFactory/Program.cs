using System;
//-----------------------------------------------------------------
// CarFactory
//
// Name: David Zientara
// Date: 7-21-2022
// Comments: An exercise in using factory patterns
// Added methods per the instructions
//-----------------------------------------------------------------


namespace FactoryPattern
{
    class Program
    {
        // The "client" will query the user for a vehicle,
        // then create the vehicle per their instructions
        public static void Main()
        {
            String? userVehicle;
            ICallable theVehicle;
            Console.WriteLine("What kind of vehicle do you want (car, motorcycle, truck or SUV)?");
            do
            {
                userVehicle = Console.ReadLine();
            } while (userVehicle == null); // Keep going until you get valid input

            // Now that there's valid input, crate an object and "build" it:
            if (userVehicle != null)
            {
                theVehicle = VehicleFactory.GetVehicle(userVehicle);
                theVehicle.Build();
            }
            

        }
    }
}