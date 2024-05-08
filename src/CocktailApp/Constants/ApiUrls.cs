using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocktailApp.Constants
{
    internal class ApiUrls
    {
        public const string RANDOM_COCKTAIL = @"https://www.thecocktaildb.com/api/json/v1/1/random.php";
        public const string FILTER_COCKTAIL_BY_NAME = @"https://www.thecocktaildb.com/api/json/v1/1/search.php?s=";
        public const string COCKTAIL_START_WITH = @"https://www.thecocktaildb.com/api/json/v1/1/search.php?f=";
    }
}
