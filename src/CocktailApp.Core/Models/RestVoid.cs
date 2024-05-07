namespace CocktailApp.Core.Models;

public class RestVoid

{
    public RestVoid()
    {
    }
    private static RestVoid? empty;
    public static RestVoid Empty => empty ??= new RestVoid();
}
