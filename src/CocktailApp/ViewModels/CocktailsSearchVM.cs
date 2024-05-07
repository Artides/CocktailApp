using CocktailApp.Core.Services;

namespace CocktailApp.ViewModels;

internal class CocktailsSearchVM : BaseViewModel
{
    public CocktailsSearchVM(INavigationService navigationService) : base(navigationService)
    {
    }
}
