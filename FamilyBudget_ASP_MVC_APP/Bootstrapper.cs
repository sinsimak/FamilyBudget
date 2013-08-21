using System.Web.Mvc;
using FamilyBudgetDAL.IRepositories;
using FamilyBudgetDAL.Repositories;
using FamilyBudget_ASP_MVC_APP.WcfServices;
using FamilyBudget_ASP_MVC_APP.WcfServices.Interfaces;
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
            container.RegisterType<IBudgetService, BudgetService>();

            return container;
        }
    }
}