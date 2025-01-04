namespace DeathStarTrafficManager.Domain.Interfaces;

public interface IPilot
{
    public Guid PilotId { get; }
    public string Name { get; }
    public string BirthYear { get; }
    public Guid PlanetId { get; }

    void SetName(string pilotName);
    void SetBirthYear(string year);
}