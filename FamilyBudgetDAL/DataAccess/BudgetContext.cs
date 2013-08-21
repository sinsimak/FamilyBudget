using System.Data.Entity;
using FamilyBudgetDAL.DomainClasses;

namespace FamilyBudgetDAL.DataAccess
{
    public class BudgetContext : DbContext
    {
        public DbSet<Budget> Budgets { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<PaymentType> PaymentTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new BudgetConfiguration());
            modelBuilder.Configurations.Add(new PaymentConfiguration());
            modelBuilder.Configurations.Add(new PaymentTypeConfiguration());
        }
    }
}
