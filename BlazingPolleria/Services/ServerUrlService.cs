namespace BlazingPolleria.Services;
public class ServerUrlService
{
    private readonly IHttpContextAccessor _httpContextAccessor;

    public ServerUrlService(IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;
    }

    public string GetServerBaseAddress()
    {
        var httpContext = _httpContextAccessor.HttpContext;
        if (httpContext == null)
        {
            throw new InvalidOperationException("No HTTP context is available.");
        }

        var request = httpContext.Request;
        return $"{request.Scheme}://{request.Host}/";
    }
}

