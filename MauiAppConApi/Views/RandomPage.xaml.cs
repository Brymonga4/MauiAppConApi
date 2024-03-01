using MauiAppConApi.ViewModels;

namespace MauiAppConApi.Views;

public partial class RandomPage : ContentPage
{
	public RandomPage(RandomViewModel randomViewModel)
	{
		InitializeComponent();
		BindingContext = randomViewModel;
	}
}