namespace CocktailApp.Services
{
    internal interface IIngredientService
    {
        Task<Ingredient?> GetIngredientDetail(string name);
        Task<IEnumerable<Ingredient>?> GetAllIngredients();

    }
}
