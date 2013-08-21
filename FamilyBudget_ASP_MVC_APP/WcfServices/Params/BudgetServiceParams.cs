using FamilyBudgetDAL.IRepositories;

namespace FamilyBudget_ASP_MVC_APP.WcfServices.Params
{
    public class BudgetServiceParams
    {
        public IBudgetRepository BudgetRepository { get; private set; }

        public BudgetServiceParams(IBudgetRepository budgetRepository)
        {
            BudgetRepository = budgetRepository;
        }
    }
}