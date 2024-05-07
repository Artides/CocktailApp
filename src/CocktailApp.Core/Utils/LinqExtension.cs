namespace CocktailApp.Core.Utils;

public static class LinqExtension
{

    public static bool NullOrEmpty<TSource>(this IEnumerable<TSource> source) => source == null || !source.Any();
    public static bool Empty<TSource>(this IEnumerable<TSource> source) => !source.Any();
    public static bool NotContains<TSource>(this IEnumerable<TSource> source, TSource item) => !source.Contains(item);
    public static bool NotAny<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate) => !source.Any(predicate);
}
