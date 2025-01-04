using DeathStarTrafficManager.Domain.Interfaces;

namespace DeathStarTrafficManager.Domain.Entities;

public class Planet : IPlanet
{
    public Guid PlanetId { get; private set; }
    public string Name { get; private set; }
    public float Rotation { get; private set; }
    public float Orbit { get; private set; }
    public float Diameter { get; private set; }
    public string Weather { get; private set; }
    public int Population { get; private set; }

    internal Planet()
    {
    }

    public Planet(string name, float rotation, float orbit, float diameter, string weather, int population)
    {
        this.Name = name;
        this.Rotation = rotation;
        this.Orbit = orbit;
        this.Diameter = diameter;
        this.Weather = weather;
        this.Population = population;
    }

    public void ChangeName(string newPlanetName)
    {
        this.Name = newPlanetName;
    }

    public void ChangeRotation(float newRotation)
    {
        this.Rotation = newRotation;
    }

    public void ChangeOrbit(float newOrbit)
    {
        this.Orbit = newOrbit;
    }

    public void ChangeDiameter(float newDiameter)
    {
        this.Diameter = newDiameter;
    }

    public void ChangeWeather(string newWeather)
    {
        this.Weather = newWeather;
    }

    public void ChangePopulation(int newPopulation)
    {
        this.Population = newPopulation;
    }
}