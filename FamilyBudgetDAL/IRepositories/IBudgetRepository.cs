using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FamilyBudgetDAL.DomainClasses;

namespace FamilyBudgetDAL.IRepositories
{
    public interface IBudgetRepository : IDisposable
    {
        IEnumerable<Budget> GetBudgets();
        Budget GetBudgetById(int budgetId);
        void InsertBudget(Budget budget);
        void DeleteBudget(int budgetId);
        void UpdateBudget(Budget budget);
        void Save();
    }
}
