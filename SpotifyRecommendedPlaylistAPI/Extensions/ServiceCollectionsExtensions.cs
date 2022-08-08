using SpotifyRecommendedPlaylistAPI.Data.Repositories;
using SpotifyRecommendedPlaylistAPI.Data.RepositoryInterfaces;
using Microsoft.Extensions.DependencyInjection;

namespace SpotifyRecommendedPlaylistAPI.Extensions
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
