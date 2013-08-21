using System.Runtime.Serialization;

namespace FamilyBudget_ASP_MVC_APP.WcfServices.DataContracts
{
    [DataContract]
    public class GetBudgetResponse
    {
        [DataMember]
        public string Name { get; set; }
    }
}