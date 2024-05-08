using CommunityToolkit.Mvvm.ComponentModel;

namespace CocktailApp.ViewModels;

internal partial class CocktailDetailVM : BaseViewModel
{
    [ObservableProperty]
    Drink? drink;

    public CocktailDetailVM(INavigationService navigationService) : base(navigationService)
    {
    }

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
}
