using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiAppConApi.Dtos;
using MauiAppConApi.Models;
using MauiAppConApi.Services;
using System.Collections.ObjectModel;
using System.Diagnostics;


namespace MauiAppConApi.ViewModels
{
    public partial class LocationsViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<LocationDto> locations;
        [ObservableProperty]
        private Uri nextPageUri;
        private readonly LocationsService locationsService;
        public LocationsViewModel(LocationsService locationsService)
        {
            this.locationsService = locationsService;
            Locations = new ObservableCollection<LocationDto>();

            nextPageUri = new Uri("https://rickandmortyapi.com/api/location/?page=1");

            LoadLocations(nextPageUri);
        }

        private async Task LoadLocations(Uri uri)
        {
            if (NextPageUri != null)
            {
                var locationResults = await locationsService.GetLocationsWithPage(uri);
                foreach (var location in locationResults.Results)
                {
                    Locations.Add(location.AsDto());
                }
                if (locationResults.Info.Next != null)
                {
                    NextPageUri = new Uri(locationResults.Info.Next);
                }
                else
                {
                    NextPageUri = null;
                };
            }
        }

        [RelayCommand]
        private async Task LoadNextPage()
        {
            LoadLocations(NextPageUri);
        }

        [RelayCommand]
        private async Task GoTo()
        {
            var num = 2;
            Trace.WriteLine("mando location2 " + num);
            await Shell.Current.GoToAsync("locationdetail", new ShellNavigationQueryParameters { { "ideal", num } });
            //await Shell.Current.GoToAsync($"characterdetail?id={num}");


        }

    }
}
