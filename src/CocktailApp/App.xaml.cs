using CocktailApp.Core.Services;

namespace CocktailApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            InitializeServices();
            Current.UserAppTheme = AppTheme.Light;
            MainPage = new AppShell();
        }

        private static void InitializeServices()
        {
            ServiceLocatorHelper.GetService<INavigationService>()?.RegisterRoutes();
        }
    }
}
