namespace CocktailApp.Models;

internal class DrinksDTO
{
    [JsonProperty("drinks")]
    public List<Drink>? Drinks { get; set; }
}
