using ARM.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace ARM.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeTitle> EmployeeTitle { get; set; }
        public DbSet<Menu> Menu { get; set; }
        public DbSet<MenuCategory> MenuCategory { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<OrderStatus> OrderStatus { get; set; }
        public DbSet<PaymentType> PaymentType { get; set; }
        public DbSet<Reservation> Reservation { get; set; }
        public DbSet<ReservationStatus> ReservationStatus { get; set; }
        public DbSet<Tables> Tables { get; set; }
        public DbSet<TableStatus> TableStatus { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }

        protected AppDbContext()
        {
        }
    }
}
