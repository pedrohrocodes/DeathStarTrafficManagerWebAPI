using DeathStarTrafficManager.Domain.Interfaces;

namespace DeathStarTrafficManager.Domain.Entities;

public class Ship : IShip
{
    public Guid ShipId { get; private set; }
    public string Name { get; private set; }
    public string Model { get; private set; }
    public int Passengers { get; private set; }
    public float LoadCapacity { get; private set; }
    public string ShipClass { get; private set; }

    internal Ship()
    {
    }

    public Ship(string name, string model, int passengers, float loadCapacity, string shipClass)
    {
        this.Name = name;
        this.Model = model;
        this.Passengers = passengers;
        this.LoadCapacity = loadCapacity;
        this.ShipClass = shipClass;
    }

    public void ChangeName(string shipName)
    {
        this.Name = shipName;
    }

    public void ChangeModel(string shipModel)
    {
        this.Model = shipModel;
    }

    public void ChangePassengers(int passengers)
    {
        this.Passengers = passengers;
    }

    public void ChangeLoadCapacity(float capacity)
    {
        this.LoadCapacity = capacity;
    }

    public void ChangeClass(string shipClass)
    {
        this.ShipClass = shipClass;
    }
}