

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiAppConApi.Dtos;
using MauiAppConApi.Services;
using System.Diagnostics;

namespace MauiAppConApi.ViewModels;

[QueryProperty(nameof(Id), "id")]
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

        Trace.WriteLine("Recibo el numero al crear el viewmodel " + Id);
        //LoadRandomLocationWithResidents();
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

    public async Task LoadLocationWithResidentsById()
    {
        Trace.WriteLine("Recibo el numero en loadcharacter " + Id);
        var location = await locationsService.GetLocationWithResidentsById(Id);

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

    [RelayCommand]
    private async Task GoToCharacterDetail(int id)
    {
        Trace.WriteLine("Leo del control " + id);

        await Shell.Current.GoToAsync($"characterdetail?id={id}");

    }



}
