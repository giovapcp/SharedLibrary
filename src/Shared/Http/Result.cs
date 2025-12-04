namespace Shared.Http;

public class Result<T>
{
    public bool IsError { get; }
    public Exception? Error { get; }
    public T? Payload { get; }
    public int StatusCode { get; }

    public Result(Exception error, int statusCode = 500)
    {
        IsError = true;
        Error = error;
        Payload = default;
        StatusCode = statusCode;
    }

    public Result(T payload, int statusCode = 200)
    {
        IsError = false;
        Error = null;
        Payload = payload;
        StatusCode = statusCode;
    }
}
