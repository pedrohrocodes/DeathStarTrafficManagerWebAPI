namespace DeathStarTrafficManager.Contracts.Contracts;

public class PlanetDto
{
    public string Name { get; set; }
    public string Rotation_Period { get; set; }
    public string Orbital_Period { get; set; }
    public string Diameter { get; set; }
    public string Climate { get; set; }
    public string Population { get; set; }
    public string Url { get; set; }

    public float Rotation
    {
        get
        {
            float.TryParse(Rotation_Period, out var rotationPeriod);
            return rotationPeriod;
        }
    }

    public float Orbit
    {
        get
        {
            float.TryParse(Orbital_Period, out var orbitalPeriod);
            return orbitalPeriod;
        }
    }
    
    public float PlanetDiameter
    {
        get
        {
            float.TryParse(Diameter, out var diameter);
            return diameter;
        }
    }

    public int PlanetPopulation
    {
        get
        {
            int.TryParse(Population, out var population);
            return population;
        }
    }
}