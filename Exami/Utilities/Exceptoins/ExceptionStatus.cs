namespace Utilities.Exceptoins;

// Define the Status enum to categorize exceptions
[Flags]
public enum ExceptionStatus
{
    Error,   // Logical error (e.g., invalid input, business rule violation)
    Fail     // System failure (e.g., database connection issue, external service downtime)
}
