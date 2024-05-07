using CocktailApp.Core.Exceptions;
using CocktailApp.Core.Models;
using CocktailApp.Core.Utils;
using Newtonsoft.Json;
using System.Net;

namespace CocktailApp.Core.Services
{
    public class ApiManager : IApiManager
    {
        public async Task<RestResult<TOut>> GetAsync<TOut>(string url) where TOut : class
        {
            try
            {
                if (!InternetHelper.IsInternetReachable())
                    return new RestResult<TOut>(HttpStatusCode.InternalServerError, new NoInternetConnectionException());
                using (var client = new HttpClient())
                {
                    if (typeof(TOut) == typeof(byte[]))
                    {
                        var resultByteArray = await client.GetByteArrayAsync(url);
                        return new RestResult<TOut>(HttpStatusCode.OK, resultByteArray as TOut);
                    }
                    else
                    {
                        var result = await client.GetAsync(url);
                        if (result.IsSuccessStatusCode)
                        {
                            if (typeof(TOut) == typeof(RestVoid))
                            {
                                return new RestResult<TOut>(result.StatusCode, RestVoid.Empty as TOut);
                            }
                            else
                            {
                                if (result.StatusCode == HttpStatusCode.NoContent)
                                {
                                    var nocontent = Activator.CreateInstance<TOut>();
                                    return new RestResult<TOut>(result.StatusCode, nocontent);
                                }
                                var response = await result.Content.ReadAsStringAsync();
                                var returnValue = JsonConvert.DeserializeObject<TOut>(response, new JsonSerializerSettings
                                {
                                    NullValueHandling = NullValueHandling.Ignore
                                });
                                return new RestResult<TOut>(result.StatusCode, returnValue);
                            }
                        }

                        var error = await result.Content.ReadAsStringAsync() ?? string.Empty;
                        return new RestResult<TOut>(result.StatusCode, new ApiException(error, result.StatusCode));
                    }
                }
            }
            catch (Exception ex)
            {
                return new RestResult<TOut>(HttpStatusCode.InternalServerError, ex);
            }
        }
    }
}
