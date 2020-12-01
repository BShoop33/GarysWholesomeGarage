using System;
using System.Collections.Generic;

namespace GarysWholesomeGarage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero();
            Zero fx = new Zero();
            Tesla modelS = new Tesla();

            List<IElectricVehicle> electricVehicles = new List<IElectricVehicle>() {
                fx, fxs, modelS
            };
            
            Console.WriteLine("Electric Vehicles");
            foreach(IElectricVehicle ev in electricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage}");
            }

            foreach(IElectricVehicle ev in electricVehicles)
            {
                // This should charge the vehicle to 100%
                ev.ChargeBattery();
            }

            foreach(IElectricVehicle ev in electricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage}");
            }

            /***********************************************/

            // Ram ram = new Ram ();
            // Cessna cessna150 = new Cessna ();

            // List<???> gasVehicles = new List<???>() {
            //     ram, cessna150
            // };

            // Console.WriteLine("Gas Vehicles");
            // foreach(??? gv in gasVehicles)
            // {
            //     Console.WriteLine($"{gv.CurrentTankPercentage}");
            // }

            // foreach(??? gv in gasVehicles)
            // {
            //     // This should completely refuel the gas tank
            //     gv.RefuelTank();
            // }

            // foreach(??? gv in gasVehicles)
            // {
            //     Console.WriteLine($"{gv.CurrentTankPercentage}");
            // }


        }

        // static void Main(string[] args)
        // {
        //     Tesla myTesla = new Tesla();
        //     Ram myRam = new Ram();
        //     Cessna myCessna = new Cessna();
        //     Zero myZero = new Zero();

        //     myZero.MainColor = "Midnight Blue";
        //     myZero.Drive();
        //     myZero.Turn();
        //     myZero.Stop();

        //     myZero.MainColor = "Black";
        //     myZero.Drive();
        //     myZero.Turn();
        //     myZero.Stop();

        //     myTesla.Drive();
        //     myTesla.Turn();
        //     myTesla.Stop();

        //     myRam.Drive();
        //     myRam.Turn();
        //     myRam.Stop();

        //     myCessna.Drive();
        //     myCessna.Turn();
        //     myCessna.Stop();
        // }
    }
}
