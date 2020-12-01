using System;

public class Ram : Vehicle, IIceVehicles  // Gas powered truck
{
    public double FuelCapacity { get; set; }

    public double CurrentTankPercentage { get; } = 100.0;

    public void RefuelTank()
    {
       Console.WriteLine("The Ram fuel tank is now completely refilled");
    }
    
    public override void Drive()
    {
        Console.WriteLine("The Silver Ram growls past. Rrrrrrruuummmmbbbble!");
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