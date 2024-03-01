

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiAppConApi.Dtos;
using MauiAppConApi.Models;
using MauiAppConApi.Services;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace MauiAppConApi.ViewModels;

public partial class HomeViewModel : ObservableObject
{
    [ObservableProperty]
    private ObservableCollection<CharacterDto> characters;
    [ObservableProperty]
    private Uri nextPageUri;
    [ObservableProperty]
    private CharacterDto? selectedCharacter;

    [ObservableProperty]
    private ObservableCollection<CharacterDto> filteredCharacters;

    [ObservableProperty]
    private string searchText;

    private readonly CharactersService charactersService;

    public HomeViewModel(CharactersService characterService)
    {
        this.charactersService = characterService;

        //Characters = new ObservableCollection<CharacterDto>();
        FilteredCharacters = new ObservableCollection<CharacterDto>();
        nextPageUri = new Uri("https://rickandmortyapi.com/api/character?status=dead");
        LoadCharactersDead(NextPageUri);

        // FilteredCharacters = new ObservableCollection<CharacterDto>(Characters);
    }


    private async Task LoadCharactersDead(Uri uri)
    {
        if (NextPageUri != null)
        {
            var charactersResults = await charactersService.GetCharactersWithPage(uri);
            var tempCharacters = new ObservableCollection<CharacterDto>();
            foreach (var character in charactersResults.Results)
            {
                tempCharacters.Add(character.AsDto());
            }
            FilteredCharacters = tempCharacters;
        }

    }


    [RelayCommand]
    private async Task LoadNextPage()
    {
        await LoadCharactersDead(NextPageUri);
    }

    [RelayCommand]
    private async Task ShowAboutAsync()
    {
        // Navegación a rutas absolutas
        await Shell.Current.GoToAsync("//about");
    }

    [RelayCommand]
    public async Task FilterCharacters(string searchText)
    {
        if (string.IsNullOrWhiteSpace(searchText))
        {
            await LoadCharactersDead(NextPageUri);
        }
        else
        {
            var filtered = FilteredCharacters.Where(c => c.Name.ToLower().Contains(searchText.ToLower()));
            FilteredCharacters = new ObservableCollection<CharacterDto>(filtered);
        }
    }


    [RelayCommand]
    private async Task ShowDetail()
    {
        // Navegación a rutas relativas
        //await Shell.Current.GoToAsync("details");

        // Navegación por parámetros mediante datos primitivos (si la página a navegar va a obtener los datos a partir de una nueva consulta)
        //await Shell.Current.GoToAsync($"details?id={SelectedCosa.Id}");

        // Navegación por objetos de uso múltiple (si la página a navegar es una página intermedia)
        //await Shell.Current.GoToAsync("details", new Dictionary<string, object> { { "Cosa", SelectedCosa } });

        // Navegación por objetos de uso único (si la página a navegar es una página final)
        //await Shell.Current.GoToAsync("details", new ShellNavigationQueryParameters { { "Cosa", SelectedCosa } });
        Trace.WriteLine(SelectedCharacter.Id);
        await Shell.Current.GoToAsync($"characterdetail?id={SelectedCharacter.Id}");
    }

    partial void OnSearchTextChanged(string value)
    {
        FilterCharacters(value); 
    }
}
