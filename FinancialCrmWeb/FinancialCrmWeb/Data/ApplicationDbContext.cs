using Microsoft.EntityFrameworkCore;
using FinancialCrmWeb.Models;

namespace FinancialCrmWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; } = default!;
    }
}
