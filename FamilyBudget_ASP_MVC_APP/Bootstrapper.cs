using System.Web.Mvc;
using FamilyBudgetDAL.IRepositories;
using FamilyBudgetDAL.Repositories;
using Microsoft.Practices.Unity;
using Unity.Mvc3;

namespace FamilyBudget_ASP_MVC_APP
{
    public static class Bootstrapper
    {
        public static void Initialise()
        {
            var container = BuildUnityContainer();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();
            container.RegisterType<IBudgetRepository, BudgetRepository>();

            return container;
        }
    }
}