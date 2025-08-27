using Microsoft.Extensions.DependencyInjection;
using Saturn.Domain.Services;
using Saturn.Infrastructure.Services;

namespace Saturn.Infrastructure.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection Register(this IServiceCollection serviceCollection)
    {
        return serviceCollection.AddTransient<ITestService, TestService>();
    }
}