using MauiAppConApi.ViewModels;

namespace MauiAppConApi.Views;

public partial class AboutPage : ContentPage
{
	public AboutPage(AboutViewModel aboutViewModel)
	{
		InitializeComponent();
		BindingContext = aboutViewModel;
	}
}