namespace Library.Exceptions;

public class BadInputException : Exception
{
    public BadInputException(string? message = null) : base(message)
    {

    }
}