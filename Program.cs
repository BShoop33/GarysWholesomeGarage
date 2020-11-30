using System;

namespace GarysWholesomeGarage
{
    class Program
    {
        static void Main(string[] args)
        {
            Tesla myTesla = new Tesla();
            Ram myRam = new Ram();
            Cessna myCessna = new Cessna();
            Zero myZero = new Zero();

            myZero.MainColor = "Midnight Blue";
            myZero.Drive();
            myZero.Turn();
            myZero.Stop();
            
            myZero.MainColor = "Black";
            myZero.Drive();
            myZero.Turn();
            myZero.Stop();

            myTesla.Drive();
            myTesla.Turn();
            myTesla.Stop();

            myRam.Drive();
            myRam.Turn();
            myRam.Stop();

            myCessna.Drive();
            myCessna.Turn();
            myCessna.Stop();
        }
    }
}
