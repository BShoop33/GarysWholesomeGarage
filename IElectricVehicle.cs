public interface IElectricVehicle
{
    double BatteryKWh { get; set; }

    double CurrentChargePercentage { get; }

    void ChargeBattery();
}