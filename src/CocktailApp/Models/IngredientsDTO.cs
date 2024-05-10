namespace CocktailApp.Models
{
    internal class IngredientsDTO
    {
        [JsonProperty("ingredients")]
        public List<Ingredient> Ingredients { get; set; }
    }
}
