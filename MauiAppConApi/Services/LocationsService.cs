using MauiAppConApi.Data;
using MauiAppConApi.Dtos;
using MauiAppConApi.Models;
using System.Diagnostics;

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

    public async Task<LocationDto> GetRandomLocation()
    {
        var location = await restService.GetLocationRandom();
        return location.AsDto();
    }
    public async Task<LocationAndResidentsDto> GetRandomLocationWithResidents()
    {
        var location = await restService.GetLocationRandom();

        List<CharacterDto> residents = new List<CharacterDto>();
        Trace.WriteLine("resident that live in " + location.Name +" - " +location.Id);
        foreach(var resident in location.Residents)
        {
            var uri = new Uri(resident);
            var residentCharacter = await restService.GetCharacterByUri(uri);
            Trace.WriteLine(residentCharacter.Name);
            residents.Add(residentCharacter.AsDto());
        }

        var locationandresidents = new LocationAndResidentsDto (location.Id,location.Name,
                                                                location.Type,location.Dimension, 
                                                                residents);

        return locationandresidents;
    }


}
