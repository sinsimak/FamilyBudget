using System.Runtime.Serialization;

namespace FamilyBudget_ASP_MVC_APP.WcfServices.DataContracts
{
    [DataContract]
    public class GetBudgetRequest
    {
        [DataMember]
        public int BudgetId { get; set; }
    }
}