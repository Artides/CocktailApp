using CocktailApp.Core.Services;

namespace CocktailApp.Services;

public class NavigationService : NavigationServiceBase
{
	public override void RegisterRoutes()
	{
		base.RegisterRoutes();
		Routing.RegisterRoute(nameof(MainPageVM), typeof(MainPage));
	}
}
