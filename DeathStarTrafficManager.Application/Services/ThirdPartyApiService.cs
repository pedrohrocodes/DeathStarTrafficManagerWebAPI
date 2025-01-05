using System.Net.Http.Json;
using DeathStarTrafficManager.Contracts.Contracts;
using DeathStarTrafficManager.Contracts.Reponses;
using DeathStarTrafficManager.Contracts.Services;
using DeathStarTrafficManager.Domain.Constants;
using DeathStarTrafficManager.Domain.Entities;

namespace DeathStarTrafficManager.Application.Services;

public class ThirdPartyApiService : IThirdPartyApiService
{
    public async Task Syncronyze()
    {
        await GetPlanetsAsync();
    }

    public async Task<IEnumerable<PlanetDto>> GetPlanetsAsync()
    {
        var httpClient = new HttpClient();
        var planetList = new List<PlanetDto>();

        ThirdPartyApiResponse<PlanetDto> thirdPartyApiResponse = null;

        do
        {
            thirdPartyApiResponse = await httpClient.GetFromJsonAsync<ThirdPartyApiResponse<PlanetDto>>(
                thirdPartyApiResponse.Next ??
                ThirdPartyApiConstants.API_PLANETS_URL);

            planetList.AddRange(thirdPartyApiResponse.Results);
        } while (thirdPartyApiResponse.Next != null);

        return planetList;
    }

    public Task GetShipsAsync()
    {
        throw new NotImplementedException();
    }

    public Task GetPilotsAsync()
    {
        throw new NotImplementedException();
    }
}