using CocktailApp.Models;

namespace CocktailApp.Services;

internal interface ICocktailService
{
    Task<IEnumerable<Drink>?> SearchDrinkByName(string? name);
    Task<Drink?> GetRandomDrink();
    Task<IEnumerable<Drink>?> GetDrinksByFirstLetter(char letter);

}
