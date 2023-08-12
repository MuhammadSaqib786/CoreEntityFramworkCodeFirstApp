using Microsoft.EntityFrameworkCore;

namespace CoreEntityFramworkCodeFirstApp.Models
{
    public class ApplicationDbContext: DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-C2FV00T\\SQLEXPRESS;Database=CodeFirstDb;Integrated Security=true;TrustServerCertificate=true");
        }

    }
}
