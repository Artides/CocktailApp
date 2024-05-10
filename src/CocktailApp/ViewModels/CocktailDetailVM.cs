using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace CocktailApp.ViewModels;

internal partial class CocktailDetailVM(INavigationService navigationService) : BaseViewModel(navigationService)
{
    [ObservableProperty]
    Drink? drink;

    public static (string, object)[] GetNavigationParameter(Drink? drink)
    {
        var query = new List<(string, object)>();

        if (drink != null) query.Add((nameof(Drink), drink));

        return [.. query];
    }

    public override void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        if (query.NullOrEmpty()) return;

        if (query.TryGetValue(nameof(Drink), out object? value)) Drink = value as Drink;
    }

    [RelayCommand]
    void GoToIngredientDetail(string? selectedIngredient)
    {
        _navigationService.NavigateToPage(nameof(IngredientDetailVM), IngredientDetailVM.GetNavigationParameter(selectedIngredient));

    }
}
