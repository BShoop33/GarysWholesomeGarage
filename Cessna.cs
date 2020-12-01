using System;

public class Cessna : Vehicle  // Propellor light aircraft
{
    public double FuelCapacity { get; set; }

    public override void RefuelTank()
    {
        
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