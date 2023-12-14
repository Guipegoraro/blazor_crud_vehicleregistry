using VehiclesRegistry.Client.Models;

namespace VehiclesRegistry.Client;

public static class VehicleClient
{
    private static readonly List<Vehicle> vehicles = new()
    {
        new Vehicle()
        {
            Id = 1,
            Model = "Fiesta",
            Year = 2005,
            Price = 12900f,
            BuyingDate = new DateTime(2017, 2, 5)

        },
        new Vehicle()
        {
            Id = 2,
            Model = "Focus",
            Year = 2008,
            Price = 19900f,
            BuyingDate = new DateTime(2015, 2, 5)

        },
        new Vehicle()
        {
            Id = 3,
            Model = "Ka",
            Year = 2002,
            Price = 12200f,
            BuyingDate = new DateTime(2008, 2, 5)

        }
    };
    public static Vehicle[] GetVehicles()
    {
        return vehicles.ToArray();
    }

    public static void AddVehicle(Vehicle vehicle)
    {
        vehicle.Id = vehicles.Max(vehicle => vehicle.Id) + 1;
        vehicles.Add(vehicle);
    }



}