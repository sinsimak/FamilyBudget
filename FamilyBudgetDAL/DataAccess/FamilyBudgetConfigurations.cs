using System.Data.Entity.ModelConfiguration;
using FamilyBudgetDAL.DomainClasses;

namespace FamilyBudgetDAL.DataAccess
{
    internal class BudgetConfiguration : EntityTypeConfiguration<Budget>
    {
        public BudgetConfiguration()
        {
            Property(b => b.Name).IsRequired().HasMaxLength(200);
            Property(b => b.StartDate).IsRequired();
            Property(b => b.EndDate).IsRequired();
        }
    }

    internal class PaymentConfiguration : EntityTypeConfiguration<Payment>
    {
        public PaymentConfiguration()
        {
            Property(p => p.Description).IsRequired().HasMaxLength(500);
            Property(p => p.PlannedAmount).IsRequired();
        }
    }

    internal class PaymentTypeConfiguration : EntityTypeConfiguration<PaymentType>
    {
        public PaymentTypeConfiguration()
        {
            Property(pt => pt.Name).IsRequired().HasMaxLength(300);
        }
    }
}
