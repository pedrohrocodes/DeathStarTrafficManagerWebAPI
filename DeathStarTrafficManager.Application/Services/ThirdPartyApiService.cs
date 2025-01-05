using System.Net.Http.Json;
using DeathStarTrafficManager.Contracts.Contracts;
using DeathStarTrafficManager.Contracts.Services;
using DeathStarTrafficManager.Domain.Constants;

namespace DeathStarTrafficManager.Application.Services;

public class ThirdPartyApiService : IThirdPartyApiService
{
    public Task Syncronyze()
    {
        throw new NotImplementedException();
    }

    public async Task GetPlanetsAsync()
    {
        var httpClient = new HttpClient();
        var planetList = new List<PlanetDto>();
        
        ApiResult<PlanetDto> apiResult = null;

        do
        {
            apiResult = await httpClient.GetFromJsonAsync<ApiResult<PlanetDto>>(apiResult?.Next ?? ThirdPartyApiConstants.API_PLANETS_URL);
            planetList.Add(apiResult.Results);
        } while (apiResult.Next != null);
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