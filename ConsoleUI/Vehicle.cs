using System;
using Microsoft.VisualBasic;

namespace ConsoleUI;

public abstract class Vehicle
{
    public string Year { get; set; } = "Default valueYear";
    public string Make { get; set; } = "Default valueMake";
    public string Model { get; set; } = "Default valueModel";

    public abstract void DriveAbstract();

    public virtual void DriveVirtual()
    {
        Console.WriteLine("Default Virtual Drive Method");
    }
}