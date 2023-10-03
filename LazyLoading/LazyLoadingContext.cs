using System.Data.Entity;

namespace LazyLoading
{
    public class LazyLoadingContext : DbContext
    {
        public DbSet<City> Cities { get; set; }
        public DbSet<Area> Areas { get; set; }
    }
}
