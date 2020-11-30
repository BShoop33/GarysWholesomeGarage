using System;

public class Zero : Vehicle  // Electric motorcycle
{
    public double BatteryKWh { get; set; }
    
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







    public override void ChargeBattery()
    {
        Console.WriteLine("60kWH");
    }

    
}