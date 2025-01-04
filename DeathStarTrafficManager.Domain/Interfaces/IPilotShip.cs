namespace DeathStarTrafficManager.Domain.Interfaces;

public interface IPilotShip
{
    Guid PilotId { get; }
    Guid ShipId { get; }
    bool IsAuthorized { get; }
    
    void Authorize();
    void Deny();
}