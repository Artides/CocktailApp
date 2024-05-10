using CocktailApp.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace CocktailApp.ViewModels;

internal partial class CocktailsStaticSearchVM : BaseViewModel
{
    private readonly ICocktailService _cocktailService;

    [ObservableProperty]
    IEnumerable<Drink>? filteredDrinks;

    [ObservableProperty]
    string? searchString;

    [ObservableProperty]
    bool initCompleted;

    List<Drink> _allDrinks = [];

    public CocktailsStaticSearchVM(INavigationService navigationService, ICocktailService cocktailService) : base(navigationService)
    {
        _cocktailService = cocktailService;
    }

    public override Task OnAppearing()
    {
        InitCompleted = false;

        Task.Run(() =>
        {
            if (SearchString.IsNotEmpty())
                UpdateDrinkList(SearchString);
            else
                LoadAllDrinks();
            InitCompleted = true;
        });

        return Task.CompletedTask;
    }


    [RelayCommand]
    void GoToDetail(Drink selectedDrink)
    {
        KeyboardHelper.Hide();
        _navigationService.NavigateToPage(nameof(CocktailDetailVM), CocktailDetailVM.GetNavigationParameter(selectedDrink));
    }

    async void LoadAllDrinks()
    {
        var result = await _cocktailService.GetAllDrinks();
        if (result != null) _allDrinks.AddRange(result);

        FilteredDrinks = _allDrinks;
    }

    partial void OnSearchStringChanged(string? value)
    {
        UpdateDrinkList(value);
    }

    private void UpdateDrinkList(string? value)
    {
        if (value.IsEmpty())
        {
            FilteredDrinks = _allDrinks;
        }
        else
        {
            FilteredDrinks = _allDrinks.Where(x => x.StrDrink?.Contains(value, StringComparison.CurrentCultureIgnoreCase) == true);
        }
    }
}