using ElChefe.Domain.Entities;

namespace ElChefe.Application.Services.Authentication;

public record AuthenticationResult(
    User User,
    string Token);

