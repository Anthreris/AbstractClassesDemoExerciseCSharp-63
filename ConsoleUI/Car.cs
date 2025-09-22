using System;

namespace ConsoleUI;

public class Car : Vehicle
{
    public bool HasTrunk { get; set; }
    
    public override void DriveAbstract()
    {
        Console.WriteLine("This car drives mediumly fast, steers reasonably, and can brake quickly");
    }

    public override void DriveVirtual()
    {
        Console.WriteLine("Car's Virtual Drive Method");
    }
}