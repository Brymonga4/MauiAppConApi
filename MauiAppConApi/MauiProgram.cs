using MauiAppConApi.Data;
using MauiAppConApi.Repositories;
using MauiAppConApi.Services;
using MauiAppConApi.ViewModels;
using MauiAppConApi.Views;
using Microsoft.Extensions.Logging;

namespace MauiAppConApi
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
            builder.Services.AddSingleton<DummyService>();

            builder.Services.AddSingleton<HomeViewModel>();
            builder.Services.AddSingleton<HomePage>();

            builder.Services.AddSingleton<CharactersService>();
            builder.Services.AddSingleton<CharactersViewModel>();
            builder.Services.AddSingleton<CharactersPage>();

            builder.Services.AddSingleton<CharacterDetailViewModel>();
            builder.Services.AddSingleton<CharacterDetailPage>();

            builder.Services.AddSingleton<LocationDetailViewModel>();
            builder.Services.AddSingleton<LocationDetailPage>();

            builder.Services.AddSingleton<LocationsService>();
            builder.Services.AddSingleton<LocationsViewModel>();
            builder.Services.AddSingleton<LocationsPage>();

            

            builder.Services.AddSingleton<AboutViewModel>();
            builder.Services.AddSingleton<AboutPage>();

            builder.Services.AddSingleton<RestService>();
#endif

            return builder.Build();
        }
    }
}
