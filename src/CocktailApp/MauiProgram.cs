using Microsoft.Extensions.Logging;

namespace CocktailApp
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
					fonts.AddFontAwesome();
				});

#if DEBUG
			builder.Logging.AddDebug();
#endif

			var app = builder.Build();

			ServiceLocatorHelper.Init(app);

			return app;
		}
	}
}
