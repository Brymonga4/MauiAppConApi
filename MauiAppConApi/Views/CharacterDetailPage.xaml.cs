using MauiAppConApi.ViewModels;

namespace MauiAppConApi.Views;

public partial class CharacterDetailPage : ContentPage
{
    private readonly CharacterDetailViewModel characterDetailViewModel;
    public CharacterDetailPage(CharacterDetailViewModel characterDetailViewModel)
	{
		InitializeComponent();
		this.characterDetailViewModel = characterDetailViewModel;
		BindingContext = characterDetailViewModel;
	}

    protected override async void OnAppearing()
    {
        base.OnAppearing();
       // await this.characterDetailViewModel.LoadRandomCharacter();
       await this.characterDetailViewModel.LoadCharacterById();
    }

}