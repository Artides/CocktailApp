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

        [JsonIgnore]
        public bool HasStrDescription => StrDescription.IsNotEmpty();

        [JsonProperty("strType")]
        public string? StrType { get; set; }

        [JsonProperty("strAlcohol")]
        public string? StrAlcohol { get; set; }

        [JsonIgnore]
        public string? StrAlcoholic => StrAlcohol?.Equals("Yes", StringComparison.InvariantCultureIgnoreCase) == true ? "Alcoholic" : "Not alcoholic";

        [JsonProperty("strABV")]
        public string? StrABV { get; set; }

        [JsonIgnore]
        public string? ThumbnailSmall => @$"https://www.thecocktaildb.com/images/ingredients/{StrIngredient}-Small.png";
        public string? Thumbnail => @$"https://www.thecocktaildb.com/images/ingredients/{StrIngredient}-Medium.png";
    }
}
