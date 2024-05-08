using CocktailApp.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace CocktailApp.ViewModels;

internal partial class MainPageVM(INavigationService navigationService, ICocktailService cocktailService) : BaseViewModel(navigationService)
{
    private readonly ICocktailService _cocktailService = cocktailService;

    [ObservableProperty]
    ObservableCollection<Drink>? randomDrinks = null;

    [ObservableProperty]
    bool drinksAvailables;

    public override Task OnAppearing()
    {
        DrinksAvailables = false;
        Task.Run(() =>
        {

            int numberOfRandomDrinks = 4;

            Task<Drink?>[] tasks = new Task<Drink?>[numberOfRandomDrinks];
            for (int i = 0; i < numberOfRandomDrinks; i++)
            {
                tasks[i] = _cocktailService.GetRandomDrink();
            }
            Task.WaitAll(tasks);

            List<Drink> drinks = [];
            foreach (var t in tasks)
            {
                if (t.Result == null) continue;
                drinks.Add(t.Result);
            }

            DrinksAvailables = true;
            RandomDrinks = new ObservableCollection<Drink>(drinks);
        });
        return Task.CompletedTask;
    }

    [RelayCommand]
    void SearchDrink() 
    {
        _navigationService.NavigateToPage(nameof(CocktailsSearchVM));
    }

}
