namespace Utilities.Exceptoins;

public class AppException : Exception
{
    public ExceptionStatus Status { get; }

    public AppException(string message, ExceptionStatus status)
        : base(message)
    {
        Status = status;
    }

    public AppException(string message, ExceptionStatus status, Exception innerException)
        : base(message, innerException)
    {
        Status = status;
    }
}
