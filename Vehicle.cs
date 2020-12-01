using System;

public class Vehicle
{
    public string MainColor { get; set; }
    public string MaximumOccupancy { get; set; }

    public virtual void Drive()
    {
        Console.WriteLine("Basic Drive");
    }

    public virtual void Turn ()
    {
        Console.WriteLine("Basic Turn");
    }

    public virtual void Stop ()
    {
        Console.WriteLine("Basic Stop");
    }
}