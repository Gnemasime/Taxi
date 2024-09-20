using Taxi.Models;

namespace Taxi.Data;


    public class TaxiContext : DbContext
    {
        public TaxiContext(DbContextOptions<TaxiContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<Taxi> Taxis { get; set; }
        public DbSet<Trip> Trips { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .Property(u => u.UserType)
                .HasConversion<string>();  // Store enum as string in the database
        }
    }
