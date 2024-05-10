using CocktailApp.Services;
using CommunityToolkit.Mvvm.ComponentModel;

namespace CocktailApp.ViewModels;

internal partial class IngredientDetailVM(INavigationService navigationService, IIngredientService ingredientService) : BaseViewModel(navigationService)
{
    [ObservableProperty]
    Ingredient? ingredient;

    string IngredientName = string.Empty;

    public static (string, object)[] GetNavigationParameter(string? ingredientName)
    {
        var query = new List<(string, object)>
        {
            (nameof(IngredientName), ingredientName ?? string.Empty)
        };

        return [.. query];
    }

    public override void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        if (query.ContainsKey(nameof(IngredientName))) IngredientName = query[nameof(IngredientName)] as string ?? string.Empty;
    }
    public override Task OnAppearing()
    {
        _ = RefreshDetail();

        return base.OnAppearing();
    }

    private async Task RefreshDetail()
    {
        Ingredient ??= await ingredientService.GetIngredientDetail(IngredientName);
    }

}
