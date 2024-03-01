
using CommunityToolkit.Mvvm.Input;
using MauiAppConApi.Views;
using System.Diagnostics;

namespace MauiAppConApi
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            InitializeRouting();
        }

        private static void InitializeRouting()
        {
            Routing.RegisterRoute("home/characters", typeof(CharactersPage));
            Routing.RegisterRoute("home/locations", typeof (LocationsPage));
            Routing.RegisterRoute("characterdetail", typeof(CharacterDetailPage));
            Routing.RegisterRoute("locationdetail", typeof(LocationDetailPage));
            Routing.RegisterRoute("about", typeof(AboutPage));
        }

 
    }
}
