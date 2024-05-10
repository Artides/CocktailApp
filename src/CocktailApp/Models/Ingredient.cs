namespace CocktailApp.Models
{
    internal class Ingredient
    {
        [JsonProperty("idIngredient")]
        public string? IdIngredient { get; set; }

        [JsonProperty("strIngredient")]
        public string? StrIngredient { get; set; }

        [JsonProperty("strDescription")]
        public string? StrDescription { get; set; }

        [JsonProperty("strType")]
        public string? StrType { get; set; }

        [JsonProperty("strAlcohol")]
        public string? StrAlcohol { get; set; }

        [JsonProperty("strABV")]
        public string? StrABV { get; set; }
    }
}
