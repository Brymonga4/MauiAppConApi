using MauiAppConApi.ViewModels;

namespace MauiAppConApi.Views;

public partial class LocationsPage : ContentPage
{
	public LocationsPage(LocationsViewModel locationsViewModel)
	{
		InitializeComponent();
		BindingContext = locationsViewModel;
	}
}