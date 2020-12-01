using System;

public class Tesla : Vehicle, IElectricVehicle  // Electric car
{
    public double BatteryKWh { get; set; }
  
    public double CurrentChargePercentage { get; } = 99.3;

    public void ChargeBattery()
    {
       Console.WriteLine("Tesla battery charged to 100%");
    }

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
}