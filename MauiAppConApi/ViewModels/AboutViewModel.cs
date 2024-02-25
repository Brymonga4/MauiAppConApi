
using CommunityToolkit.Mvvm.ComponentModel;
using MauiAppConApi.Models;
using MauiAppConApi.Services;
using System.Collections.ObjectModel;

namespace MauiAppConApi.ViewModels;

public partial class AboutViewModel : ObservableObject
{
    [ObservableProperty]
    private ObservableCollection<Cosa> cosas;
    [ObservableProperty]
    private Cosa selectedCosa;

    public AboutViewModel(DummyService dummyService)
    {
        var servicio = dummyService;
        Cosas = new ObservableCollection<Cosa>(servicio.GetAllCosas());
    }
}
