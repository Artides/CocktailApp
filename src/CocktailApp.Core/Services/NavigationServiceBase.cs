namespace CocktailApp.Core.Services;

public class NavigationServiceBase : INavigationService
{
	public void NavigateBack(params (string, object)[] parameters)
	{
		var dictionary = new Dictionary<string, object>();

		if (parameters != null && parameters.Length != 0)
			foreach (var p in parameters) dictionary.TryAdd(p.Item1, p.Item2);

		Shell.Current.GoToAsync("..", dictionary);
	}

	public void NavigateToPage(string pageRoute, params (string, object)[] parameters)
	{
		var dictionary = new Dictionary<string, object>();

		if (parameters != null && parameters.Length != 0)
			foreach (var p in parameters) dictionary.TryAdd(p.Item1, p.Item2);

		Shell.Current.GoToAsync(pageRoute, dictionary);
	}

	public virtual void RegisterRoutes()
	{
	}
}
