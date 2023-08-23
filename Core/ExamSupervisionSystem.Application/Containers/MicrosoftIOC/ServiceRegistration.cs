
using System.Reflection;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace ExamSupervisionSystem.Application.Containers.MicrosoftIOC;

public static class ServiceRegistration
{
    public static IServiceCollection AddApplicationRegistration(this IServiceCollection services)
    {
        var assembly = Assembly.GetExecutingAssembly();
        return services
            .AddAutoMapper(assembly)
            .AddMediatR(conf => conf.RegisterServicesFromAssemblies(assembly))
            .AddValidatorsFromAssemblyContaining(typeof(ServiceRegistration));
    }
}