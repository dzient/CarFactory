using System;
//-----------------------------------------------------------------
// CarFactory
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
// IVehicle 
// An interface which defines properties common to vehicles

public interface IVehicle
{
    public string Year { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public int Wheels { get; set; }
    // A Drive method; we will implement it in the derived classes
    public void Drive();

}
