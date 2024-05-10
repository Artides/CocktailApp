using CocktailApp.ViewModels;
using CocktailApp.Views.Pages;

namespace CocktailApp.Services;

public class NavigationService : NavigationServiceBase
{
	public override void RegisterRoutes()
	{
		base.RegisterRoutes();
        Routing.RegisterRoute(nameof(CocktailsSearchVM), typeof(CocktailsSearchPage));
        Routing.RegisterRoute(nameof(CocktailsStaticSearchVM), typeof(CocktailsStaticSearchPage));
        Routing.RegisterRoute(nameof(CocktailDetailVM), typeof(CocktailDetailPage));
        Routing.RegisterRoute(nameof(IngredientsSearchVM), typeof(IngredientSearchPage));
        Routing.RegisterRoute(nameof(IngredientDetailVM), typeof(IngredientDetailPage));
    }
}
