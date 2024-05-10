using CocktailApp.Core.Services;
using CocktailApp.Services;

namespace CocktailApp.Ioc
{
    internal static class ServicesRegistration
    {
        internal static MauiAppBuilder AddServices(this MauiAppBuilder builder)
        {

            builder.Services
                .AddSingleton<INavigationService, NavigationService>()
                .AddSingleton<IApiManager, ApiManager>()
                .AddSingleton<ITranslationService, TranslationService>()
                .AddSingleton<ICocktailService, CocktailService>()
                .AddSingleton<IIngredientService, IngredientService>()
                ;

            return builder;
        }
    }
}
