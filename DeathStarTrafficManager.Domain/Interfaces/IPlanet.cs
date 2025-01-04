namespace DeathStarTrafficManager.Domain.Interfaces;

public interface IPlanet
{
    Guid PlanetId { get; }
    string Name { get; }
    float Rotation { get; }
    float Orbit { get; }
    float Diameter { get; }
    string Weather { get; }
    int Population { get; }
    
    void ChangeName(string newPlanetName);
    void ChangeRotation(float newRotation);
    void ChangeOrbit(float newOrbit);
    void ChangeDiameter(float newDiameter);
    void ChangeWeather(string newWeather);
    void ChangePopulation(int newPopulation);
}