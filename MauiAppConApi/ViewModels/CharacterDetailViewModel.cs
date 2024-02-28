
using CommunityToolkit.Mvvm.ComponentModel;
using MauiAppConApi.Dtos;
using MauiAppConApi.Services;
using System.Diagnostics;


namespace MauiAppConApi.ViewModels;

[QueryProperty("Id", "Id")]
//[QueryProperty(nameof(CharacterDto), nameof(CharacterDto))]
public partial class CharacterDetailViewModel : ObservableObject
{
    [ObservableProperty]
    private int id;
    [ObservableProperty]
    private Uri charUri;
    [ObservableProperty]
    private CharacterDto? character;

    private readonly CharactersService charactersService;

    public CharacterDetailViewModel(CharactersService charactersService)
    {
        this.charactersService = charactersService;
        Trace.WriteLine("Recibo el numero " + Id);
        //LoadCharacterById(Id);
        LoadRandomCharacter();
    }

    private async Task LoadCharacterById(int id)
    {
        Trace.WriteLine("Recibo el numero "+id);
         var character =  await charactersService.GetById(id);
        Character = character;

    }

    public async Task LoadRandomCharacter()
    {
        var character = await charactersService.GetRandomCharacter();
        Character = character;

    }

}
