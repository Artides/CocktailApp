using System.Globalization;

namespace CocktailApp.Core.Utils;

public static class StringExtension
{
    public static bool IsEmpty(this string str) => string.IsNullOrWhiteSpace(str);
    public static bool IsNotEmpty(this string str) => !string.IsNullOrWhiteSpace(str);
    public static bool EqualsTo(this string str, string value) => str.Equals(value, StringComparison.InvariantCultureIgnoreCase);

    public static string Translate(this string str, params object?[] pars)
    {
        var locStr = str;//TODO: AppRes.ResourceManager.GetString(str);

        if (!string.IsNullOrWhiteSpace(locStr))
            try
            {
                locStr = string.Format(CultureInfo.CurrentCulture, locStr, pars);
            }
            catch (Exception)
            {
            }

        return locStr ?? str;
    }


}
