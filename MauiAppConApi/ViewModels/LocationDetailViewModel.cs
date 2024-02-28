

using CommunityToolkit.Mvvm.ComponentModel;
using MauiAppConApi.Dtos;
using MauiAppConApi.Services;
using System.Diagnostics;

namespace MauiAppConApi.ViewModels;

[QueryProperty(nameof(Id), "ideal")]
public partial class LocationDetailViewModel : ObservableObject
{
    [ObservableProperty]
    private int id;
    [ObservableProperty]
    private LocationDto? location;
    [ObservableProperty]
    private LocationAndResidentsDto? locationWithResidents;

    private readonly LocationsService locationsService;
    public LocationDetailViewModel(LocationsService locationsService)
    {
        this.locationsService = locationsService;

       // LoadRandomLocation();
        LoadRandomLocationWithResidents();
    }

    public async Task LoadRandomLocationWithResidents()
    {
        var location = await locationsService.GetRandomLocationWithResidents();

        if (location.Residents.Count == 0)
        {
            var noResident = new CharacterDto(0, "No one", "Unknown", "Unknown",
                "Unknown", "Unknown",
                null, null,
                "https://rickandmortyapi.com/api/character/avatar/19.jpeg");

            location.Residents.Add(noResident);
        }
        LocationWithResidents = location;
    }

    public async Task LoadRandomLocation()
    {
        var location = await locationsService.GetRandomLocation();
        Location = location;

    }

}
