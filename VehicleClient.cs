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
            BodyType = "Hatch",
            BuyingDate = new DateTime(2017, 2, 5)

        },
        new Vehicle()
        {
            Id = 2,
            Model = "Fusion",
            Year = 2008,
            Price = 33900f,
            BodyType = "Sedan",
            BuyingDate = new DateTime(2015, 2, 5)

        },
        new Vehicle()
        {
            Id = 3,
            Model = "Ka",
            Year = 2002,
            Price = 12200f,
            BodyType = "Hatch",
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

    public static Vehicle GetVehicle(int id)
    {
        return vehicles.Find(vehicle => vehicle.Id == id) ?? throw new Exception("Veículo não encontrado!");
    }

    public static void UpdateVehicle(Vehicle updatedVehicle)
    {
        Vehicle existingVehicle = GetVehicle(updatedVehicle.Id);
        existingVehicle.Model = updatedVehicle.Model;
        existingVehicle.Year = updatedVehicle.Year;
        existingVehicle.Price = updatedVehicle.Price;
        existingVehicle.BodyType = updatedVehicle.BodyType;
        existingVehicle.BuyingDate = updatedVehicle.BuyingDate;

    }

        public static void DeleteVehicle(int id)
    {
        Vehicle vehicle = GetVehicle(id);
        vehicles.Remove(vehicle);
    }

}