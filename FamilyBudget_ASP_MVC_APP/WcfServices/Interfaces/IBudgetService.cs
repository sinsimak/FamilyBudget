using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using FamilyBudget_ASP_MVC_APP.Dto;
using FamilyBudget_ASP_MVC_APP.WcfServices.DataContracts;

namespace FamilyBudget_ASP_MVC_APP.WcfServices.Interfaces
{
    [ServiceContract]
    public interface IBudgetService
    {
        [OperationContract]
        GetBudgetResponse GetBudget(GetBudgetRequest request);

        [OperationContract]
        BudgetDto GetBudgetById(int budgetId);
    }
}
