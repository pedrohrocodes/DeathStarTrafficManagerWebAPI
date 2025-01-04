using DeathStarTrafficManager.Domain.Interfaces;

namespace DeathStarTrafficManager.Domain.Entities;

public class TripHistory : ITripHistory
{
    public Guid ShipId { get; }
    public Guid PilotId { get; }
    public DateTime DepartureDate { get; private set; }
    public DateTime? ArrivalDate { get; private set; }

    public TripHistory(Guid shipId, Guid pilotId, DateTime departureDate)
    {
        this.ShipId = shipId;
        this.PilotId = pilotId;
        this.DepartureDate = departureDate;
        this.ArrivalDate = null;
    }

    public void SetDepartureDate(DateTime departureDate)
    {
        this.DepartureDate = departureDate;
    }

    public void SetArrivalDate(DateTime arrivalDate)
    {
        this.ArrivalDate = arrivalDate;
    }
}