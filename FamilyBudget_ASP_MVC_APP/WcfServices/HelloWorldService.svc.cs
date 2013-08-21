using System;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;

namespace FamilyBudget_ASP_MVC_APP.WcfServices
{
    [ServiceContract(Namespace = "")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class HelloWorldService
    {
        [OperationContract]
        public string GetWord()
        {
            string word = "Здравствуйте!";
            return word;
        }

        // Add more operations here and mark them with [OperationContract]
    }
}
