using Microsoft.EntityFrameworkCore;

namespace MVC.Demo
{
    public class CustomerDbContext : DbContext
    {
        public CustomerDbContext(DbContextOptions<CustomerDbContext> options)
        : base(options)
        {
        }

        protected override void OnConfiguring
       (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "OrderManagementSystem");
        }

        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(
            new Customer { Id = 1, FirstName = "Joydip", LastName = "Kanjilal", Address = "Hyderabad, India", Phone = "1234567890" },
            new Customer { Id = 2, FirstName = "Steve", LastName = "Smith", Address = "Chicago, USA", Phone = "5566778899" },
            new Customer { Id = 3, FirstName = "Debanjan", LastName = "Banerjee", Address = "Kolkata, India", Phone = "0987654321" });
        }
    }
}