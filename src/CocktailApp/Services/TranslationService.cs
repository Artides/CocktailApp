using CocktailApp.Core.Services;
using CocktailApp.Resources.Strings;

namespace CocktailApp.Services;

internal class TranslationService : ITranslationService
{
    public string GetString(string key)
    {
        return AppRes.ResourceManager?.GetString(key) ?? string.Empty;
    }
}
