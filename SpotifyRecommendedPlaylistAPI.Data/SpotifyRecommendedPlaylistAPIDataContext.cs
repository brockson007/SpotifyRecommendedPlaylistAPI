using SpotifyRecommendedPlaylistAPI.Data.Models;
using SpotifyRecommendedPlaylistAPI.Data.Models.Mapping;
using Microsoft.EntityFrameworkCore;

namespace SpotifyRecommendedPlaylistAPI.Data
{
    public class SpotifyRecommendedPlaylistAPIDataContext : DbContext
    {
        #region Constructors
        public SpotifyRecommendedPlaylistAPIDataContext(DbContextOptions<SpotifyRecommendedPlaylistAPIDataContext> options):base(options)
        {

        }

        #endregion Constructors

        #region Properties
        internal string DatabaseConnectionString { get; private set; }
        #endregion Properties

        #region DBSet Properties
        public DbSet<User> Users { get; set; }
        #endregion DBSet Properties

        #region OnModelCreating
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMap());
        }
        #endregion OnModelCreating
    }
}
