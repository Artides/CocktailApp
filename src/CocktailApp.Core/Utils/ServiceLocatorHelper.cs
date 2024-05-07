namespace CocktailApp.Core.Utils;

public static class ServiceLocatorHelper
{
	private static MauiApp? App;

	public static void Init(MauiApp app) => App = app;

	public static T? GetService<T>()
	{
		if (App == null) throw new ArgumentNullException(nameof(MauiApp));
		return App.Services.CreateScope().ServiceProvider.GetService<T>();
	}

}
