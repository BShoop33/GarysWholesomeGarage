using System;

public class Tesla : Vehicle  // Electric car
{
    public double BatteryKWh { get; set; }

    public override void Drive()
    {
        Console.WriteLine("The Burgundy Tesla blazes by you. MMmmmmmmmmmm!");
    }

    public override void Turn()
    {
        Console.WriteLine("The Burgundy Tesla squeals around a right turn.");
    }

    public override void Stop()
    {
        Console.WriteLine("The Burgundy Tesla silently stops as if it never moved.\n");
    }


    public override void ChargeBattery()
    {
        Console.WriteLine();
    }
}