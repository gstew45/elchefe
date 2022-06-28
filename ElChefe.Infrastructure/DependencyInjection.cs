using ElChefe.Application.Common.Interfaces.Authentication;
using ElChefe.Application.Common.Interfaces.Persistance;
using ElChefe.Application.Common.Interfaces.Services;
using ElChefe.Infrastructure.Authentication;
using ElChefe.Infrastructure.Persistance;
using ElChefe.Infrastructure.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ElChefe.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, ConfigurationManager configuration)
    {
        services.Configure<JwtSettings>(configuration.GetSection(JwtSettings.SectionName));
        services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
        services.AddSingleton<IDateTimeProvider, DateTimeProvider>();
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IRecipeRepository, RecipeRepository>();
        return services;
    }
}
