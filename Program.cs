using System;

namespace GarysWholesomeGarage
{
    class Program
    {
        static void Main(string[] args)
        {
            Tesla myTesla = new Tesla();
            // myTesla.MaximumOccupancy = "100";
            // Console.WriteLine(myTesla.MaximumOccupancy);
        
            Ram myRam = new Ram();
            Cessna myCessna = new Cessna();
            Zero myZero = new Zero();

            myTesla.Drive();
            myRam.Drive();
            myCessna.Drive();
            myZero.Drive();

        }
    }
}
