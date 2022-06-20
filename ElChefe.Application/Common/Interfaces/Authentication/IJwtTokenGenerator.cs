using ElChefe.Domain.Entities;

namespace ElChefe.Application.Common.Interfaces.Authentication;

public interface IJwtTokenGenerator
{
    string GenerateToken(User user);
}
