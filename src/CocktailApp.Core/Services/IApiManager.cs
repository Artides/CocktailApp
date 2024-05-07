using CocktailApp.Core.Models;

namespace CocktailApp.Core.Services;

public interface IApiManager
{
    Task<RestResult<TOut>> GetAsync<TOut>(string url) 
        where TOut : class;

    Task<RestResult<TOut>> PostAsync<TOut, TIn>(string url, TIn body) 
        where TOut: class 
        where TIn : class;

    Task<RestResult<TOut>> PutAsync<TOut, TIn>(string url, TIn body) 
        where TOut: class 
        where TIn : class;

    Task<RestResult> DeleteAsync(string url);

}
