using CocktailApp.Constants;

namespace CocktailApp.Services;

internal class IngredientService(IApiManager ApiManager) : IIngredientService
{
    public async Task<Ingredient?> GetIngredientDetail(string name)
    {
        var response = await ApiManager.GetAsync<IngredientsDTO>(ApiUrls.INGREDIENT_DETAIL + name);
        if (response.IsSuccess) return response.Content?.Ingredients?.FirstOrDefault(x => x.StrIngredient?.Equals(name, StringComparison.InvariantCultureIgnoreCase) == true);

        return null;
    }

    public async Task<IEnumerable<Ingredient>?> GetAllIngredients()
    {
        var response = await ApiManager.GetAsync<DrinksDTO>(ApiUrls.INGREDIENT_LIST);
        if (response.IsSuccess) return response.Content?.Drinks?.OrderBy(x => x.StrIngredient1).Select(x => new Ingredient() { StrIngredient = x.StrIngredient1 });

        return null;


    }
}
