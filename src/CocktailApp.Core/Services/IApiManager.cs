using CocktailApp.Core.Models;

namespace CocktailApp.Core.Services;

public interface IApiManager
{
    Task<RestResult<TOut>> GetAsync<TOut>(string url) where TOut : class;
}
