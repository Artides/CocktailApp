using CocktailApp.Core.Services;

namespace CocktailApp.ViewModels;

internal class CocktailDetailVM : BaseViewModel
{
    public CocktailDetailVM(INavigationService navigationService) : base(navigationService)
    {
    }
}
