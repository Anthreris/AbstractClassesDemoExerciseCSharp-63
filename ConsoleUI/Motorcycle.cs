using System;

namespace ConsoleUI;

public class Motorcycle : Vehicle
{
    public bool HasSideCart { get; set; }
    
    public override void DriveAbstract()
    {
        Console.WriteLine("This motorcycle drives fast and is quite agile, however it is slow to brake");
    }

    public override void DriveVirtual()
    {
        Console.WriteLine("Motorcycle's Default Virtual Drive Method");
    }
}