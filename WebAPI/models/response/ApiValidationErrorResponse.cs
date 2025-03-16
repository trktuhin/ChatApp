namespace WebAPI.models.response;

public class ApiValidationErrorResponse : ErrorResponse
{
    public ApiValidationErrorResponse() : base(400)
    {
    }
    public required IEnumerable<string> Errors { get; set; }
}
