public interface IIceVehicles
{
    double FuelCapacity { get; }

    double CurrentTankPercentage { get; }

    void RefuelTank();
}