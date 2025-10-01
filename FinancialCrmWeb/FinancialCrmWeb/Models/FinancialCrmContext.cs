using Microsoft.EntityFrameworkCore;

namespace FinancialCrmWeb.Models
{
    public class FinancialCrmContext : DbContext
    {
        public FinancialCrmContext(DbContextOptions<FinancialCrmContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Bank> Banks { get; set; }
        public DbSet<BankProcess> BankProcesses { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Spending> Spendings { get; set; }
    }
}
