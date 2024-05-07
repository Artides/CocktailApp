namespace CocktailApp.Core.Services;

public interface INavigationService
{
	void RegisterRoutes();

	void NavigateToPage(string pageRoute, params (string, object)[] parameters);

	void NavigateBack(params (string, object)[] parameters);

}
