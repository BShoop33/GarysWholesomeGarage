using System;

public class Ram : Vehicle  // Gas powered truck
{
    public double FuelCapacity { get; set; }

    public override void RefuelTank()
    {
       
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