using LOCALIZACarsInDotNet.Core.Enums;

namespace LOCALIZACarsInDotNet.Core.Entites;

public class Vehicle
{
    public int Id { get; set; }
    
    public string Plate { get; set;  }
    
    public string Brand { get; set; }
    
    public string Model { get; set; }
    
    public int Year { get; set; }
    
    public double Miliage { get; set; }
    
    public decimal DailyRate { get; set; }
    
    public VehicleCategory VehicleCategory { get; set; }
    
    public VehicleStatus VehicleStatus { get; set; }


    public Vehicle(int id, string plate, string brand, string model, int year, double miliage, decimal dailyRate, VehicleCategory vehicleCategory, VehicleStatus vehicleStatus)
    {
        Id = id;
        Plate = plate;
        Brand = brand;
        Model = model;
        Year = year;
        Miliage = miliage;
        DailyRate = dailyRate;
        VehicleCategory = vehicleCategory;
        VehicleStatus = vehicleStatus;
    }
}