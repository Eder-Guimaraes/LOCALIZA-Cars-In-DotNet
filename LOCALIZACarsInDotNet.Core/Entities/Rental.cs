using LOCALIZACarsInDotNet.Core.Entites;
using LOCALIZACarsInDotNet.Core.Enums;

namespace LOCALIZACarsInDotNet.Core.Entities;

public class Rental
{
    internal int costumerId;

    public int Id { get; set; }
    
    public Costumer Costumer { get; set; }
    
    public Vehicle Vehicle { get; set; }
    
    public DateTime StartDate { get; set; }
    
    public DateTime ExpectedReturnDate { get; set; }
    
    public DateTime ReturnDate { get; set; }
    
    public decimal DailyRate { get; set; }
    
    public double InitialMiliage { get; set; }
    
    public double FinalMiliage { get; set; }
    
    public RentalStatus RentalStatus { get; set; }


    public Rental(int id, Costumer costumer, Vehicle vehicle, DateTime startDate, DateTime expectedReturnDate, DateTime returnDate, decimal dailyRate, double initialMiliage, double finalMiliage, RentalStatus rentalStatus)
    {
        Id = id;
        Costumer = costumer;
        Vehicle = vehicle;
        StartDate = startDate;
        ExpectedReturnDate = expectedReturnDate;
        ReturnDate = returnDate;
        DailyRate = dailyRate;
        InitialMiliage = initialMiliage;
        FinalMiliage = finalMiliage;
        RentalStatus = rentalStatus;
    }
}