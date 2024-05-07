using CocktailApp.Core.Services;
using CocktailApp.ViewModels;
using CocktailApp.Views.Pages;

namespace CocktailApp.Services;

public class NavigationService : NavigationServiceBase
{
	public override void RegisterRoutes()
	{
		base.RegisterRoutes();
        Routing.RegisterRoute(nameof(CocktailsSearchVM), typeof(CocktailsSearchPage));
        Routing.RegisterRoute(nameof(CocktailDetailVM), typeof(CocktailDetailPage));
    }
}
