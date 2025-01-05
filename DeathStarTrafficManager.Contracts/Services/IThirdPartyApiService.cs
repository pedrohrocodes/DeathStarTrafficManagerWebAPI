using DeathStarTrafficManager.Contracts.Contracts;

namespace DeathStarTrafficManager.Contracts.Services;

public interface IThirdPartyApiService
{
    Task Syncronyze();
    Task GetPlanetsAsync();
    Task GetShipsAsync();
    Task GetPilotsAsync();
}