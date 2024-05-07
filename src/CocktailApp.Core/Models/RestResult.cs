using System.Net;

namespace CocktailApp.Core.Models;


public class RestResult<TOut> : RestResult
{
    public TOut? Content { get; protected set; }

    public RestResult(HttpStatusCode httpCode, TOut? content) : base(httpCode)
    {
        Content = content;
    }

    public RestResult(HttpStatusCode httpCode, Exception exception): base(httpCode, exception)
    {
            
    }

}

public class RestResult
{

    public bool IsSuccess => HttpCode == HttpStatusCode.OK;
    public Exception? Exception { get; protected set; }
    public HttpStatusCode HttpCode { get; protected set; }

    public RestResult(HttpStatusCode httpCode)
    {
        HttpCode = httpCode;
    }

    public RestResult(HttpStatusCode httpCode, Exception exception)
    {
        HttpCode = httpCode;
        Exception = exception;
    }
}
