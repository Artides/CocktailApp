namespace CocktailApp.Services;

internal class IngredientService(IApiManager ApiManager) : IIngredientService
{
    public Task<Ingredient?> GetIngredientByName(string name)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Ingredient>?> SearchIngredientByName(string? name)
    {
        throw new NotImplementedException();
    }
}
