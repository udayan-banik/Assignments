
using AssignmentHMS.Models;
using Microsoft.EntityFrameworkCore;

namespace AssignmentHMS.Data
{
    public class HMSDbContext : DbContext
    {
        public HMSDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Owner> Owners { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Payment> Payments { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    //optionsBuilder.UseSqlServer("Data Source = DESKTOP - 7IP0S9E\\SQLEXPRESS01;Initial Catalog = CoreWebAppDBContext; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        //    optionsBuilder.UseInMemoryDatabase(databaseName: "HMSDb");
        //}
    }
}
