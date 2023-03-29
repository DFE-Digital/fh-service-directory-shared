namespace FamilyHubs.ServiceDirectory.Shared.Models;

public class Result
{
    internal Result(bool succeeded, IEnumerable<string> errors)
    {
        Succeeded = succeeded;
        Errors = errors.ToArray();
    }

    public bool Succeeded { get; set; }

    public string[] Errors { get; set; }

    public static Result Success()
    {
        return new Result(true, Array.Empty<string>());
    }

    public static Result Failure(IEnumerable<string> errors)
    {
        return new Result(false, errors);
    }
}

public class Result<T> : Result
{
    public T? Value { get; private set; }

    /// <summary>
    /// Gives context to the failure messages e.g. bad request, not found, internal server error etc
    /// </summary>
    public string FailureType { get; private set; }

    public Result(string failType, IEnumerable<string> errors) : base(false, errors)
    {
        FailureType = failType;
    }

    public Result(T value, IEnumerable<string> errors) : base(true, errors) 
    {
        Value = value;
        FailureType = string.Empty;
    }

    public static Result<T> Success(T value)
    {
        return new Result<T>(value, Array.Empty<string>());
    }

    public static Result<T> Failure(string failType, IEnumerable<string> errors)
    {
        return new Result<T>(failType, errors);
    }

    public static Result<T> Failure(string failType, string error)
    {
        return new Result<T>(failType, new List<string> { error });
    }
}
