namespace WebAPI.models.response;

public class ErrorResponse
{
    public ErrorResponse(int statusCode, string? message = null)
    {
        StatusCode = statusCode;
        Message = message ?? GetDefaultMessageForStatusCode(statusCode);
    }

    public int StatusCode { get; set; }
    public string Message { get; set; }

    private string GetDefaultMessageForStatusCode(int statusCode)
    {
        return statusCode switch
        {
            400 => "You have made a bad request",
            401 => "You are unauthorized",
            404 => "Resource not found",
            500 => "Errors in server side code",
            _ => string.Empty
        };
    }
}
