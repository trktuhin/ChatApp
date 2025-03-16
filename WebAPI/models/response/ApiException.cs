namespace WebAPI.models.response;

public class ApiException : ErrorResponse
{
    public ApiException(int statusCode, string? message = null, string? details = null) : base(statusCode, message)
    {
        Details = details;
    }
    public string? Details { get; set; }
}
