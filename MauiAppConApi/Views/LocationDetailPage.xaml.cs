using MauiAppConApi.ViewModels;

namespace MauiAppConApi.Views;

public partial class LocationDetailPage : ContentPage
{private readonly LocationDetailViewModel locationDetailViewModel;
	public LocationDetailPage(LocationDetailViewModel locationDetailViewModel)
	{
		InitializeComponent();
        this.locationDetailViewModel = locationDetailViewModel;
        BindingContext = locationDetailViewModel;
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
       // await this.locationDetailViewModel.LoadRandomLocationWithResidents();
        await this.locationDetailViewModel.LoadLocationWithResidentsById();

    }

}