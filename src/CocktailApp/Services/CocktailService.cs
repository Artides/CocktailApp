using CocktailApp.Constants;
using CocktailApp.Core.Services;
using CocktailApp.Models;

namespace CocktailApp.Services;

internal class CocktailService(IApiManager ApiManager) : ICocktailService
{
    public async Task<Drink?> GetRandomDrink()
    {
        var response = await ApiManager.GetAsync<List<Drink>>(ApiUrls.RANDOM_COCKTAIL);
        if (response.IsSuccess) return response.Content?.FirstOrDefault();

        return null;
    }

    public async Task<IEnumerable<Drink>?> SearchDrinkByName(string name)
    {
        if (name.IsEmpty()) return [];

        var response = await ApiManager.GetAsync<List<Drink>>(ApiUrls.FILTER_COCKTAIL_BY_NAME + RestUtils.UrlEncode(name));
        if (response.IsSuccess) return response.Content;

        return null;
    }
}
