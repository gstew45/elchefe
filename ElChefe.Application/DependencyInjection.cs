using ElChefe.Application.Services.Authentication;
using ElChefe.Application.Services.Recipes;
using Microsoft.Extensions.DependencyInjection;

namespace ElChefe.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IAuthenticationService, AuthenticationService>();
        services.AddScoped<IRecipeService, RecipeService>();
        return services;
    }
}
