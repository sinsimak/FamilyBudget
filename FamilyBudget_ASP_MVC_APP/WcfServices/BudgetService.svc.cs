using System;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using FamilyBudget_ASP_MVC_APP.Dto;
using FamilyBudget_ASP_MVC_APP.WcfServices.DataContracts;
using FamilyBudget_ASP_MVC_APP.WcfServices.Interfaces;
using FamilyBudget_ASP_MVC_APP.WcfServices.Params;

namespace FamilyBudget_ASP_MVC_APP.WcfServices
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class BudgetService : IBudgetService 
    {
        private readonly BudgetServiceParams _budgetServiceParams;

        public BudgetService(BudgetServiceParams budgetServiceParams)
        {
            _budgetServiceParams = budgetServiceParams;
        }

        public BudgetDto GetBudgetById(int budgetId)
        {
            var budget = _budgetServiceParams.BudgetRepository.GetBudgetById(budgetId);
            BudgetDto budgetDto = new BudgetDto();
            budgetDto.Name = budget.Name;

            return budgetDto;
        }

        public GetBudgetResponse GetBudget(GetBudgetRequest request)
        {
            var budget = _budgetServiceParams.BudgetRepository.GetBudgetById(request.BudgetId);
            GetBudgetResponse getBudgetResponse = new GetBudgetResponse();
            getBudgetResponse.Name = budget.Name;

            return getBudgetResponse;
        }
    }
}
