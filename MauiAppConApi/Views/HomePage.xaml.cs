using MauiAppConApi.ViewModels;

namespace MauiAppConApi.Views
{
    public partial class HomePage : ContentPage
    {
        int count = 0;

        public HomePage(HomeViewModel homeViewModel)
        {
            InitializeComponent();
            BindingContext = homeViewModel;
        }


    }

}
