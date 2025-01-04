using DeathStarTrafficManager.Domain.Interfaces;

namespace DeathStarTrafficManager.Domain.Entities;

public class PilotShip : IPilotShip
{
    public Guid PilotId { get; }
    public Guid ShipId { get; }
    public bool IsAuthorized { get; private set; }

    internal PilotShip()
    {
    }

    public PilotShip(Guid pilotId, Guid shipId)
    {
        this.PilotId = pilotId;
        this.ShipId = shipId;
        this.IsAuthorized = true;
    }

    public void Authorize()
    {
        this.IsAuthorized = true;
    }

    public void Deny()
    {
        this.IsAuthorized = false;
    }
}