using System.Net;

namespace CocktailApp.Core.Models;


public class RestResult<TOut>
{
    public bool IsSuccess => HttpCode == HttpStatusCode.OK;
    public Exception? Exception { get; private set; }
    public TOut? Content { get; private set; }
    public HttpStatusCode HttpCode { get; private set; }

    public RestResult(HttpStatusCode httpCode, TOut? content)
    {
        HttpCode = httpCode;
        Content = content;
    }

    public RestResult(HttpStatusCode httpCode, Exception exception)
    {
        HttpCode = httpCode;
        Exception = exception;
    }

}
