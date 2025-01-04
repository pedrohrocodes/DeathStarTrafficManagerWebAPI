namespace DeathStarTrafficManager.Domain.Interfaces;

public interface IShip
{
    Guid ShipId { get; }
    string Name { get; }
    string Model { get; }
    int Passengers { get; }
    float LoadCapacity { get; }
    string ShipClass { get; }
    
    void ChangeName(string shipName);
    void ChangeModel(string shipModel);
    void ChangePassengers(int passengers);
    void ChangeLoadCapacity(float capacity);
    void ChangeClass(string shipClass);
}