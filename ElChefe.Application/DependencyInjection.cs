using ElChefe.Application.Services.Authentication;
using Microsoft.Extensions.DependencyInjection;

namespace ElChefe.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        return services.AddScoped<IAuthenticationService, AuthenticationService>();
    }
}
