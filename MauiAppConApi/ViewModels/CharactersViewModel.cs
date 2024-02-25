
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiAppConApi.Dtos;
using MauiAppConApi.Models;
using MauiAppConApi.Services;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace MauiAppConApi.ViewModels;

public partial class CharactersViewModel : ObservableObject
{
    [ObservableProperty]
    private ObservableCollection<CharacterDto> characters;
    [ObservableProperty]
    private ObservableCollection<CharacterAndInfoDto> charactersWithInfo;
    [ObservableProperty]
    private Uri nextPageUri;


    private readonly CharactersService charactersService;

    public CharactersViewModel(CharactersService charactersService)
    {
        this.charactersService = charactersService;
        Characters = new ObservableCollection<CharacterDto>();
        CharactersWithInfo = new ObservableCollection<CharacterAndInfoDto>();

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
    private async Task ShowAboutAsync()
    {
        // Navegación a rutas absolutas
        await Shell.Current.GoToAsync("//about");
    }

    public ICommand MyNavigationCommand => new Command(ExecuteMyNavigationCommand);

    private void ExecuteMyNavigationCommand()
    {
        // Lógica para navegar a otra vista
        // Puedes usar Shell.Current.GoToAsync("tuRuta") para navegar
        Console.WriteLine("hola viewmodel");
       
    }




}
