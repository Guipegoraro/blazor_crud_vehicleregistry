using System.ComponentModel.DataAnnotations;

namespace VehiclesRegistry.Client.Models;

public class Vehicle
{
    public int Id { get; set; }

    [Required]
    [StringLength(15)]
    public required string Model { get; set; }
    [Required]
    [Range(1, 3000)]
    public required int Year { get; set; }
    [Required]
    [Range(1, 100000000)]
    public required float Price { get; set; }
    [Required]
    public required string BodyType { get; set; }
    public required DateTime BuyingDate { get; set; }
}