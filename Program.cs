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
            
            Console.WriteLine("\nElectric Vehicles\n--------------------");
            foreach(IElectricVehicle ev in electricVehicles)
            {
                Console.WriteLine($"Charge is at {ev.CurrentChargePercentage}%");
            }

            foreach(IElectricVehicle ev in electricVehicles)
            {
                // This should charge the vehicle to 100%
                ev.ChargeBattery();
            }

            foreach(IElectricVehicle ev in electricVehicles)
            {
                Console.WriteLine($"Charge is at {ev.CurrentChargePercentage}%");
            }

            /***********************************************/
            Console.WriteLine("\n------------------------------------------\n");
            
            Ram ram = new Ram ();
            Cessna cessna150 = new Cessna ();

            List<IIceVehicles> gasVehicles = new List<IIceVehicles>() {
                ram, cessna150
            };

            Console.WriteLine("Gas Vehicles\n--------------------");
            foreach(IIceVehicles gv in gasVehicles)
            {
                Console.WriteLine($"Fuel tank is at {gv.CurrentTankPercentage}%");
            }

            foreach(IIceVehicles gv in gasVehicles)
            {
                // This should completely refuel the gas tank
                gv.RefuelTank();
            }

            foreach(IIceVehicles gv in gasVehicles)
            {
                Console.WriteLine($"Fuel tank is at {gv.CurrentTankPercentage}%");
            }
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
