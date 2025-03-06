namespace UI.Services;

public interface IDateTimeProvider
{
    DateTime UtcNow { get; }
}
