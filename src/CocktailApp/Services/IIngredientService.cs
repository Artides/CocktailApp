namespace CocktailApp.Services
{
    internal interface IIngredientService
    {
        Task<Ingredient?> GetIngredientByName(string name);
        Task<IEnumerable<Ingredient>?> SearchIngredientByName(string? name);

    }
}
