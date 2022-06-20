using ElChefe.Application.Common.Interfaces.Services;

namespace ElChefe.Infrastructure.Services;

public class DateTimeProvider : IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}
