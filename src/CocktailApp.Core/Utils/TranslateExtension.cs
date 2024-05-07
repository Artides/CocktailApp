
namespace CocktailApp.Core.Utils;

[ContentProperty("Text")]
public class TranslateExtension : IMarkupExtension
{
    public string Text { get; set; } = "";

    public object ProvideValue(IServiceProvider serviceProvider) => Text.Translate();
}
