using CocktailApp.ViewModels;

namespace CocktailApp.Ioc;

internal static class ViewModelRegistration
{

    internal static MauiAppBuilder AddViewModels(this MauiAppBuilder builder)
    {

        builder.Services
            .AddTransient<MainPageVM>()
            .AddTransient<CocktailsSearchVM>()
            .AddTransient<CocktailsStaticSearchVM>()
            .AddTransient<CocktailDetailVM>()
            .AddTransient<IngredientsSearchVM>()
            .AddTransient<IngredientDetailVM>()
            ;

        return builder;
    }
}
