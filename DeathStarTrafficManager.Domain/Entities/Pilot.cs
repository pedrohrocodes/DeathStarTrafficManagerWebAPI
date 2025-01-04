namespace DeathStarTrafficManager.Domain.Entities;

public class Pilot
{
    public Guid PilotId { get; private set; }
    public string Name { get; private set; }
    public string BirthYear { get; private set; }
    public Guid PlanetId { get; private set; }

    public Pilot(string name, string birthYear, Guid planetId)
    {
        this.Name = name;
        this.BirthYear = birthYear;
        this.PlanetId = planetId;
    }

    public void SetName(string name)
    {
        this.Name = name;
    }

    public void SetBirthYear(string year)
    {
        this.BirthYear = year;
    }
}