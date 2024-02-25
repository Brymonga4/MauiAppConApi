using MauiAppConApi.ViewModels;

namespace MauiAppConApi.Views;

public partial class CharactersPage : ContentPage
{
	public CharactersPage(CharactersViewModel charactersViewModel)
	{
		InitializeComponent();
		BindingContext = charactersViewModel;

    }

}