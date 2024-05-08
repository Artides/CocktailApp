using CocktailApp.Constants;
using CocktailApp.Core.Services;
using CocktailApp.Models;
using System.Xml.Linq;

namespace CocktailApp.Services;

internal class CocktailService(IApiManager ApiManager) : ICocktailService
{
    public async Task<IEnumerable<Drink>?> GetDrinksByFirstLetter(char letter)
    {
        if (!((letter >= 'a' && letter <= 'z') || (letter >= 'A' && letter <= 'Z'))) return [];

        var response = await ApiManager.GetAsync<DrinksDTO>(ApiUrls.COCKTAIL_START_WITH + letter);
        if (response.IsSuccess) return response.Content?.Drinks ?? [];

        return null;
    }

    public async Task<Drink?> GetRandomDrink()
    {
        var response = await ApiManager.GetAsync<DrinksDTO>(ApiUrls.RANDOM_COCKTAIL);
        if (response.IsSuccess) return response.Content?.Drinks?.FirstOrDefault();

        return null;
    }

    public async Task<IEnumerable<Drink>?> SearchDrinkByName(string? name)
    {
        if (name.IsEmpty()) return [];

        var response = await ApiManager.GetAsync<DrinksDTO>(ApiUrls.FILTER_COCKTAIL_BY_NAME + RestUtils.UrlEncode(name));
        if (response.IsSuccess) return response.Content?.Drinks ?? [];

        return null;
    }
}
