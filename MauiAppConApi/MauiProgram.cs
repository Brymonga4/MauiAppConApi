using MauiAppConApi.Data;
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

            //Services
            builder.Services.AddSingleton<RestService>();

            builder.Services.AddSingleton<CharactersService>();
            builder.Services.AddSingleton<LocationsService>();

            //Home page and viewmodel
            builder.Services.AddTransient<HomeViewModel>();
            builder.Services.AddTransient<HomePage>();

            //Random page and viewmodel
            builder.Services.AddTransient<RandomViewModel>();
            builder.Services.AddTransient<RandomPage>();

            //Character page and viewmodel
            builder.Services.AddTransient<CharactersViewModel>();
            builder.Services.AddTransient<CharactersPage>();

            builder.Services.AddTransient<CharacterDetailViewModel>();
            builder.Services.AddTransient<CharacterDetailPage>();

            //Location page and viewmodel
            builder.Services.AddTransient<LocationDetailViewModel>();
            builder.Services.AddTransient<LocationDetailPage>();

            builder.Services.AddTransient<LocationsViewModel>();
            builder.Services.AddTransient<LocationsPage>();

            
            //About page and viewmodel
            builder.Services.AddTransient<AboutViewModel>();
            builder.Services.AddTransient<AboutPage>();


#endif

            return builder.Build();
        }
    }
}
