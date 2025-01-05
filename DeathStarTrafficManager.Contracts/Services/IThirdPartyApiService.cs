using DeathStarTrafficManager.Contracts.Contracts;

namespace DeathStarTrafficManager.Contracts.Services;

public interface IThirdPartyApiService
{
    Task Syncronyze();
    Task<IEnumerable<PlanetDto>> GetPlanetsAsync();
    Task GetShipsAsync();
    Task GetPilotsAsync();
}