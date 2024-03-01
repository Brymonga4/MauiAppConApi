
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiAppConApi.Dtos;
using MauiAppConApi.Models;
using MauiAppConApi.Services;
using MauiAppConApi.Views;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows.Input;

namespace MauiAppConApi.ViewModels;

public partial class CharactersViewModel : ObservableObject
{
    [ObservableProperty]
    private ObservableCollection<CharacterDto> characters;

    [ObservableProperty]
    private Uri nextPageUri;


    private readonly CharactersService charactersService;

    public CharactersViewModel(CharactersService charactersService)
    {
        this.charactersService = charactersService;
        Characters = new ObservableCollection<CharacterDto>();

        nextPageUri = new Uri("https://rickandmortyapi.com/api/character/?page=1");
        // LoadCharacters();
        LoadCharactersWithNextPage(nextPageUri);
    }


    private async Task LoadCharactersWithNextPage(Uri uri)
    {
        if (NextPageUri != null)
        {
            var charactersResults = await charactersService.GetCharactersWithPage(uri);
            foreach (var character in charactersResults.Results)
            {
                Characters.Add(character.AsDto());
            }
            if (charactersResults.Info.Next != null)
            {
                NextPageUri = new Uri(charactersResults.Info.Next);
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
        LoadCharactersWithNextPage(NextPageUri);
    }

    [RelayCommand]
    private async Task GoToCharacterDetail(int id)
    {
        Trace.WriteLine("Leo del control " + id);

        await Shell.Current.GoToAsync($"characterdetail?id={id}");

    }
}
