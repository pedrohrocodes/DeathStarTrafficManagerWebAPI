namespace DeathStarTrafficManager.Domain.Interfaces;

public interface ITripHistory
{
    Guid ShipId { get; }
    Guid PilotId { get; }
    DateTime DepartureDate { get; }
    DateTime? ArrivalDate { get; }
    
    void SetDepartureDate(DateTime departureDate);
    void SetArrivalDate(DateTime arrivalDate);
}