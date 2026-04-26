using Microsoft.EntityFrameworkCore;

namespace A.Models
{
    public class UberContext : DbContext
    {
        public UberContext(DbContextOptions<UberContext> options) : base(options) { }
        public DbSet<Driver> drivers { get; set; }
        public DbSet<Ride> rides { get; set; }
        public DbSet<Vehicle_Type> vehicle_Types {  get; set; }
        public DbSet<User> users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Driver>()
                .HasOne(o => o.User)
                .WithMany(o => o.drivers)
                .HasForeignKey(o => o.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Vehicle_Type>()
                .HasOne(o => o.User)
                .WithMany(o => o.vehicles)
                .HasForeignKey(o => o.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Ride>()
                .HasOne(o => o.User)
                .WithMany(o =>o.rides)
                .HasForeignKey(o => o.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Ride>()
                .HasOne(o =>o.Driver)
                .WithMany(o => o.Rides)
                .HasForeignKey(o => o.DriverId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Ride>()
                .HasOne(o => o.VehicleType)
                .WithMany(o => o.rides)
                .HasForeignKey(o => o.VehicleId)
                .OnDelete(DeleteBehavior.NoAction);

            

        }
    }
}
