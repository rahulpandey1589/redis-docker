using redis_docker.Data.Repository.Contract;
using redis_docker.Data.Repository.Implementation;
using redis_docker.Services.Contract;
using redis_docker.Services.Implementation;

namespace redis_docker.Utils;

public static class DependencyRegistration
{
    public static IServiceCollection RegisterDbServices(
        this IServiceCollection services)
    {
        services.AddTransient<IEmployeeRepository, EmployeeRepository>();
        return services;
    }
    
    public static IServiceCollection RegisterServices(this IServiceCollection services)
    {

        services.AddTransient<IEmployeeService, EmployeeService>();
        return services;
    }
}