using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Diagnostics;

namespace MauiAppConApi.ViewModels;

public partial class RandomViewModel : ObservableObject
{
    public RandomViewModel() { }

    [RelayCommand]
    private async Task GoToCharacterRandom()
    {
        var id = GetRandomCharacterId();
        await Shell.Current.GoToAsync($"characterdetail?id={id}");

    }

    [RelayCommand]
    private async Task GoToLocationRandom()
    {
        var id = GetRandomLocationId();
        await Shell.Current.GoToAsync($"locationdetail?id={id}");

    }

    private int GetRandomLocationId()
    {
        var rand = new Random();
        int randId = rand.Next(1, 127);
        return randId;
    }

    private int GetRandomCharacterId()
    {

        var rand = new Random();
        int randId = rand.Next(1, 827);

        return randId;
    }
}
