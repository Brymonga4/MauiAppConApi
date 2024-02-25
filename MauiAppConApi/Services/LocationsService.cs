using MauiAppConApi.Data;
using MauiAppConApi.Dtos;
using MauiAppConApi.Models;

namespace MauiAppConApi.Services;

public partial class LocationsService(RestService restService) : IServices<LocationDto>
{
    private readonly RestService restService = restService;
    public async Task<List<LocationDto>> GetAll()
    {

        var locations = await restService.GetLocations(); 
        return locations.Select(location => location.AsDto()).ToList(); 
    }

    public async Task<LocationDto> GetById(int id)
    {
        var location = await restService.GetLocationById(id);
        return location.AsDto();
    }

    public async Task<LocationResults> GetLocationsWithPage(Uri uri)
    {
        var locationsResults = await restService.GetLocationsPage(uri);
        return locationsResults;

    }
}
