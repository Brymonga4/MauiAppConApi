

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiAppConApi.Models;
using MauiAppConApi.Services;
using System.Collections.ObjectModel;

namespace MauiAppConApi.ViewModels;

public partial class HomeViewModel : ObservableObject
{
    [ObservableProperty]
    private ObservableCollection<Cosa> cosas;
    [ObservableProperty]
    private Cosa selectedCosa;

    public HomeViewModel(DummyService dummyService)
    {
        //cargo las cosas del servicio
        var servicio = dummyService;
        cosas = new ObservableCollection<Cosa>(servicio.GetAllCosas());
    }

    [RelayCommand]
    private async Task ShowAboutAsync()
    {
        // Navegación a rutas absolutas
        await Shell.Current.GoToAsync("//about");
    }

    [RelayCommand]
    private async Task ShowDetailAsync()
    {
        // Navegación a rutas relativas
        //await Shell.Current.GoToAsync("details");

        // Navegación por parámetros mediante datos primitivos (si la página a navegar va a obtener los datos a partir de una nueva consulta)
        //await Shell.Current.GoToAsync($"details?id={SelectedCosa.Id}");

        // Navegación por objetos de uso múltiple (si la página a navegar es una página intermedia)
        //await Shell.Current.GoToAsync("details", new Dictionary<string, object> { { "Cosa", SelectedCosa } });

        // Navegación por objetos de uso único (si la página a navegar es una página final)
        await Shell.Current.GoToAsync("details", new ShellNavigationQueryParameters { { "Cosa", SelectedCosa } });
    }
}
