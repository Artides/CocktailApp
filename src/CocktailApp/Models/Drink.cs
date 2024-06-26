﻿using System.Globalization;
using System.Text;

namespace CocktailApp.Models;

public class Drink
{
    [JsonProperty("idDrink")]
    public string? IdDrink { get; set; }

    [JsonProperty("strDrink")]
    public string? StrDrink { get; set; }

    [JsonProperty("strDrinkAlternate")]
    public string? StrDrinkAlternate { get; set; }

    [JsonProperty("strTags")]
    public string? StrTags { get; set; }

    [JsonProperty("strVideo")]
    public string? StrVideo { get; set; }

    [JsonProperty("strCategory")]
    public string? StrCategory { get; set; }

    [JsonProperty("strIBA")]
    public string? StrIBA { get; set; }

    [JsonProperty("strAlcoholic")]
    public string? StrAlcoholic { get; set; }

    [JsonProperty("strGlass")]
    public string? StrGlass { get; set; }

    [JsonProperty("strInstructions")]
    public string? StrInstructions { get; set; }

    [JsonProperty("strInstructionsES")]
    public string? StrInstructionsES { get; set; }

    [JsonProperty("strInstructionsDE")]
    public string? StrInstructionsDE { get; set; }

    [JsonProperty("strInstructionsFR")]
    public string? StrInstructionsFR { get; set; }

    [JsonProperty("strInstructionsIT")]
    public string? StrInstructionsIT { get; set; }

    [JsonProperty("strInstructionsZH-HANS")]
    public string? StrInstructionsZHHANS { get; set; }

    [JsonProperty("strInstructionsZH-HANT")]
    public string? StrInstructionsZHHANT { get; set; }

    [JsonProperty("strDrinkThumb")]
    public string? StrDrinkThumb { get; set; }

    [JsonProperty("strIngredient1")]
    public string? StrIngredient1 { get; set; }

    [JsonProperty("strIngredient2")]
    public string? StrIngredient2 { get; set; }

    [JsonProperty("strIngredient3")]
    public string? StrIngredient3 { get; set; }

    [JsonProperty("strIngredient4")]
    public string? StrIngredient4 { get; set; }

    [JsonProperty("strIngredient5")]
    public string? StrIngredient5 { get; set; }

    [JsonProperty("strIngredient6")]
    public string? StrIngredient6 { get; set; }

    [JsonProperty("strIngredient7")]
    public string? StrIngredient7 { get; set; }

    [JsonProperty("strIngredient8")]
    public string? StrIngredient8 { get; set; }

    [JsonProperty("strIngredient9")]
    public string? StrIngredient9 { get; set; }

    [JsonProperty("strIngredient10")]
    public string? StrIngredient10 { get; set; }

    [JsonProperty("strIngredient11")]
    public string? StrIngredient11 { get; set; }

    [JsonProperty("strIngredient12")]
    public string? StrIngredient12 { get; set; }

    [JsonProperty("strIngredient13")]
    public string? StrIngredient13 { get; set; }

    [JsonProperty("strIngredient14")]
    public string? StrIngredient14 { get; set; }

    [JsonProperty("strIngredient15")]
    public string? StrIngredient15 { get; set; }

    [JsonProperty("strMeasure1")]
    public string? StrMeasure1 { get; set; }

    [JsonProperty("strMeasure2")]
    public string? StrMeasure2 { get; set; }

    [JsonProperty("strMeasure3")]
    public string? StrMeasure3 { get; set; }

    [JsonProperty("strMeasure4")]
    public string? StrMeasure4 { get; set; }

    [JsonProperty("strMeasure5")]
    public string? StrMeasure5 { get; set; }

    [JsonProperty("strMeasure6")]
    public string? StrMeasure6 { get; set; }

    [JsonProperty("strMeasure7")]
    public string? StrMeasure7 { get; set; }

    [JsonProperty("strMeasure8")]
    public string? StrMeasure8 { get; set; }

    [JsonProperty("strMeasure9")]
    public string? StrMeasure9 { get; set; }

    [JsonProperty("strMeasure10")]
    public string? StrMeasure10 { get; set; }

    [JsonProperty("strMeasure11")]
    public string? StrMeasure11 { get; set; }

    [JsonProperty("strMeasure12")]
    public string? StrMeasure12 { get; set; }

    [JsonProperty("strMeasure13")]
    public string? StrMeasure13 { get; set; }

    [JsonProperty("strMeasure14")]
    public string? StrMeasure14 { get; set; }

    [JsonProperty("strMeasure15")]
    public string? StrMeasure15 { get; set; }

    [JsonProperty("strImageSource")]
    public string? StrImageSource { get; set; }

    [JsonProperty("strImageAttribution")]
    public string? StrImageAttribution { get; set; }

    [JsonProperty("strCreativeCommonsConfirmed")]
    public string? StrCreativeCommonsConfirmed { get; set; }

    [JsonProperty("dateModified")]
    public DateTime? DateModified { get; set; }

    [JsonIgnore]
    public string IngredientsShortDescription
    {
        get
        {
            var str = new StringBuilder();
            if (StrIngredient1?.IsNotEmpty() == true) str.Append(StrIngredient1);
            if (StrIngredient2?.IsNotEmpty() == true) str.Append(", ").Append(StrIngredient2);
            if (StrIngredient3?.IsNotEmpty() == true) str.Append(", ").Append(StrIngredient3);
            if (StrIngredient4?.IsNotEmpty() == true) str.Append(", ").Append(StrIngredient4);
            if (StrIngredient5?.IsNotEmpty() == true) str.Append(", ").Append(StrIngredient5);
            if (StrIngredient6?.IsNotEmpty() == true) str.Append(", ").Append(StrIngredient6);
            if (StrIngredient7?.IsNotEmpty() == true) str.Append(", ").Append(StrIngredient7);
            if (StrIngredient8?.IsNotEmpty() == true) str.Append(", ").Append(StrIngredient8);
            if (StrIngredient9?.IsNotEmpty() == true) str.Append(", ").Append(StrIngredient9);
            if (StrIngredient10?.IsNotEmpty() == true) str.Append(", ").Append(StrIngredient10);
            if (StrIngredient11?.IsNotEmpty() == true) str.Append(", ").Append(StrIngredient11);
            if (StrIngredient12?.IsNotEmpty() == true) str.Append(", ").Append(StrIngredient12);
            if (StrIngredient13?.IsNotEmpty() == true) str.Append(", ").Append(StrIngredient13);
            if (StrIngredient14?.IsNotEmpty() == true) str.Append(", ").Append(StrIngredient14);
            if (StrIngredient15?.IsNotEmpty() == true) str.Append(", ").Append(StrIngredient15);

            if (str.Length > 22)
            {
                str.Remove(21, str.Length - 22);
                str.Append("...");
            }

            return str.ToString();
        }
    }

    [JsonIgnore]
    public List<DrinkIngredient> Ingredients
    {
        get
        {
            var list = new List<DrinkIngredient>();

            if (StrMeasure1.IsNotEmpty() && StrIngredient1?.IsNotEmpty() == true) list.Add(new DrinkIngredient(StrMeasure1, StrIngredient1));
            if (StrMeasure2.IsNotEmpty() && StrIngredient2?.IsNotEmpty() == true) list.Add(new DrinkIngredient(StrMeasure2, StrIngredient2));
            if (StrMeasure3.IsNotEmpty() && StrIngredient3?.IsNotEmpty() == true) list.Add(new DrinkIngredient(StrMeasure3, StrIngredient3));
            if (StrMeasure4.IsNotEmpty() && StrIngredient4?.IsNotEmpty() == true) list.Add(new DrinkIngredient(StrMeasure4, StrIngredient4));
            if (StrMeasure5.IsNotEmpty() && StrIngredient5?.IsNotEmpty() == true) list.Add(new DrinkIngredient(StrMeasure5, StrIngredient5));
            if (StrMeasure6.IsNotEmpty() && StrIngredient6?.IsNotEmpty() == true) list.Add(new DrinkIngredient(StrMeasure6, StrIngredient6));
            if (StrMeasure7.IsNotEmpty() && StrIngredient7?.IsNotEmpty() == true) list.Add(new DrinkIngredient(StrMeasure7, StrIngredient7));
            if (StrMeasure8.IsNotEmpty() && StrIngredient8?.IsNotEmpty() == true) list.Add(new DrinkIngredient(StrMeasure8, StrIngredient8));
            if (StrMeasure9.IsNotEmpty() && StrIngredient9?.IsNotEmpty() == true) list.Add(new DrinkIngredient(StrMeasure9, StrIngredient9));
            if (StrMeasure10.IsNotEmpty() && StrIngredient10?.IsNotEmpty() == true) list.Add(new DrinkIngredient(StrMeasure10, StrIngredient10));
            if (StrMeasure11.IsNotEmpty() && StrIngredient11?.IsNotEmpty() == true) list.Add(new DrinkIngredient(StrMeasure11, StrIngredient11));
            if (StrMeasure12.IsNotEmpty() && StrIngredient12?.IsNotEmpty() == true) list.Add(new DrinkIngredient(StrMeasure12, StrIngredient12));
            if (StrMeasure13.IsNotEmpty() && StrIngredient13?.IsNotEmpty() == true) list.Add(new DrinkIngredient(StrMeasure13, StrIngredient13));
            if (StrMeasure14.IsNotEmpty() && StrIngredient14?.IsNotEmpty() == true) list.Add(new DrinkIngredient(StrMeasure14, StrIngredient14));
            if (StrMeasure15.IsNotEmpty() && StrIngredient15?.IsNotEmpty() == true) list.Add(new DrinkIngredient(StrMeasure15, StrIngredient15));

            return list;
        }
    }

    [JsonIgnore]
    public string? Instruction => CultureInfo.CurrentCulture.TwoLetterISOLanguageName switch
    {
        "it" => StrInstructionsIT ?? StrInstructions,
        "fr" => StrInstructionsFR ?? StrInstructions,
        "de" => StrInstructionsDE ?? StrInstructions,
        "es" => StrInstructionsES ?? StrInstructions,
        _ => StrInstructions,
    };

}
