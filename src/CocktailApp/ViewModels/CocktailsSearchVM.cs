using CocktailApp.Core.Services;
using CocktailApp.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Newtonsoft.Json.Linq;

namespace CocktailApp.ViewModels;

internal partial class CocktailsSearchVM : BaseViewModel
{
    private readonly ICocktailService _cocktailService;

    [ObservableProperty]
    IEnumerable<Drink>? filteredDrinks;

    [ObservableProperty]
    string? searchString;

    char _nextLetter = 'a';
    List<Drink> _alphabeticalDrinks = [];

    public CocktailsSearchVM(INavigationService navigationService, ICocktailService cocktailService) : base(navigationService)
    {
        _cocktailService = cocktailService;
    }

    public override Task OnAppearing()
    {

        Task.Run(() =>
        {
            LoadByLetter();
        });

        return Task.CompletedTask;
    }

    [RelayCommand]
    void LoadMore()
    {
        if (SearchString.IsEmpty() && _nextLetter <= 'z')
        {
            _nextLetter++;
            LoadByLetter();
        }

    }

    [RelayCommand]
    void GoToDetail(Drink selectedDrink)
    {
        //TODO: force dismiss keyboard 
        _navigationService.NavigateToPage(nameof(CocktailDetailVM), CocktailDetailVM.GetNavigationParameter(selectedDrink));
    }

    async void LoadByLetter()
    {
        var result = await _cocktailService.GetDrinksByFirstLetter(_nextLetter);
        if (result != null) _alphabeticalDrinks.AddRange(result);

        FilteredDrinks = _alphabeticalDrinks;
    }

    partial void OnSearchStringChanged(string? value)
    {
        if (value.IsEmpty())
        {
            FilteredDrinks = _alphabeticalDrinks;
        }
        else
        {
            Task.Run(async () => FilteredDrinks = await _cocktailService.SearchDrinkByName(value));
        }

    }
}
