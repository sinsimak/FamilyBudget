using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FamilyBudgetDAL.DataAccess;
using FamilyBudgetDAL.DomainClasses;
using FamilyBudgetDAL.IRepositories;

namespace FamilyBudgetDAL.Repositories
{
    public class BudgetRepository : IBudgetRepository
    {
        private BudgetContext context;

        public BudgetRepository()
        {
            this.context = new BudgetContext();
        }

        public IEnumerable<Budget> GetBudgets()
        {
            return context.Budgets.ToList();
        }

        public Budget GetBudgetById(int budgetId)
        {
            return context.Budgets.Find(budgetId);
        }

        public void InsertBudget(Budget budget)
        {
            context.Budgets.Add(budget);
        }

        public void DeleteBudget(int budgetId)
        {
            Budget budget = GetBudgetById(budgetId);
            context.Budgets.Remove(budget);
        }

        public void UpdateBudget(Budget budget)
        {
            context.Entry(budget).State = EntityState.Modified;
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
