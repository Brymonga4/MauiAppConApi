
using CommunityToolkit.Mvvm.ComponentModel;
using MauiAppConApi.Models;
using MauiAppConApi.Services;
using System.Collections.ObjectModel;

namespace MauiAppConApi.ViewModels;

public partial class AboutViewModel : ObservableObject
{

    public AboutViewModel(DummyService dummyService)
    {
        var servicio = dummyService;

    }
}
