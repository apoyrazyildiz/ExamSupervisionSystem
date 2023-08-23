using ExamSupervisionSystem.Persistence.Concrete.EntityFrameworkCore.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ExamSupervisionSystem.Persistence.Containers.MicrosoftIOC;

public static class ServiceRegistration
{
    public static IServiceCollection AddPersistenceRegistration(this IServiceCollection services,IConfiguration configuration,string migrationName)
    {
     var connectionString = configuration.GetConnectionString("DefaultConnection");   
        services.AddDbContext<EfDbContext>(opt =>
            opt.UseSqlServer(connectionString, sqlOpt => 
            sqlOpt.MigrationsAssembly(migrationName).UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery))
        );
        return services;
    }
}