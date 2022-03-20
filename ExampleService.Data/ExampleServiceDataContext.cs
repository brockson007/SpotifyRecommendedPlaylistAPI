using ExampleService.Data.Models;
using ExampleService.Data.Models.Mapping;
using Microsoft.EntityFrameworkCore;

namespace ExampleService.Data
{
    public class ExampleServiceDataContext : DbContext
    {
        #region Constructors
        public ExampleServiceDataContext(DbContextOptions<ExampleServiceDataContext> options):base(options)
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
