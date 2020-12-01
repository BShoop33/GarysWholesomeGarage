using System;

public class Cessna : Vehicle, IIceVehicles  // Propellor light aircraft
{
    public double FuelCapacity { get; set; }

    public double CurrentTankPercentage { get; } = 99.6;

    public void RefuelTank()
    {
        Console.WriteLine("The Cessna fuel tank is now completely refilled");
    }

    public override void Drive()
    {
        Console.WriteLine("The White Cessna flashes by you like a hurricane. Zzzzzoooooommm!");
    }

    public override void Turn()
    {
        Console.WriteLine("The vehicle carefully turns right");
    }

    public override void Stop()
    {
        Console.WriteLine("The White Cessna rolls down the runway for a mile and stops.");
    }
}