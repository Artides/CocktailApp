using Microsoft.Maui.Hosting;

namespace CocktailApp.Core.Utils;

public static class FontAwesomeExtension
{

	public static IFontCollection AddFontAwesome(this IFontCollection fontCollection)
	{
		fontCollection.Add(new FontDescriptor("FA6Brands.otf", "FA6Brands", null));
		fontCollection.Add(new FontDescriptor("FA6Regular.otf", "FA6Regular", null));
		fontCollection.Add(new FontDescriptor("FA6Solid.otf", "FA6Solid", null));
		return fontCollection;
	}
}
