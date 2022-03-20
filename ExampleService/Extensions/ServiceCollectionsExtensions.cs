using ExampleService.Data.Repositories;
using ExampleService.Data.RepositoryInterfaces;
using Microsoft.Extensions.DependencyInjection;

namespace ExampleService.Extensions
{
    public static class ServiceCollectionsExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IUsersDataRepository, UsersDataRepository>();           
                                                                                                
            return services;
        }

    }
}
