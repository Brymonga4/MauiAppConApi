
using CommunityToolkit.Mvvm.ComponentModel;
using MauiAppConApi.Dtos;
using MauiAppConApi.Services;
using System.Diagnostics;


namespace MauiAppConApi.ViewModels;

[QueryProperty(nameof(Id), "id")]
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
        Trace.WriteLine("Recibo el numero al crear el viewmodel " + Id);
        //LoadCharacterById(Id);
       // LoadRandomCharacter();
    }

    public async Task LoadCharacterById()
    {
        Trace.WriteLine("Recibo el numero en loadcharacter "+ Id);
         var character =  await charactersService.GetById(Id);
        Character = character;

    }

    public async Task LoadRandomCharacter()
    {
        var character = await charactersService.GetRandomCharacter();
        Character = character;

    }

}
