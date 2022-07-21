namespace DocumentMicroservice.UI.Model
{
    public class ErrorResponse
    {
        public string ErrorMessage { get; }
        public ErrorResponse(string errorMessage)
        {
            ErrorMessage = errorMessage;
        }
    }
}
