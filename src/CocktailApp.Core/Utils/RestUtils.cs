using System.Globalization;
using System.Text;

namespace CocktailApp.Core.Utils
{
    public static class RestUtils
    {
        private const string ValidUrlCharacters =
              "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-_.~";

        public static string UrlEncode(string data)
        {
            StringBuilder encoded = new();
            foreach (char symbol in Encoding.UTF8.GetBytes(data))
            {
                if (ValidUrlCharacters.Contains(symbol))
                {
                    encoded.Append(symbol);
                }
                else
                {
                    encoded.Append('%').Append(string.Format(CultureInfo.InvariantCulture, "{0:X2}", (int)symbol));
                }
            }
            return encoded.ToString();
        }
    }
}
