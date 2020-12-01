using System;

public class Zero : Vehicle, IElectricVehicle  // Electric motorcycle
{
    public double BatteryKWh { get; set; }
    
    public double CurrentChargePercentage { get; } = 99.8;

    public void ChargeBattery()
    {
        Console.WriteLine("Zero battery charged to 100%");
    }

    public override void Drive()
    {
        Console.WriteLine($"The {MainColor} Zero zips by you! Yeeeeeoooooowwww!");
    }

    public override void Turn()
    {
        Console.WriteLine("The vehicle carefully turns right");
    }

    public override void Stop()
    {
        Console.WriteLine("The vehicle gently rolls to a stop!\n");
    }
}