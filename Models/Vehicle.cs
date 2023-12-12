namespace VehiclesRegistry.Client.Models;

public class Vehicle
{
    public int Id { get; set; }
    public required string Model { get; set; }
    public required int Year { get; set; }
    public required float Price { get; set; }
    public required DateTime BuyingDate { get; set; }
}