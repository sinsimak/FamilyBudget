using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FamilyBudgetDAL.IRepositories;

namespace FamilyBudget_ASP_MVC_APP.Controllers
{
    public class BudgetController : Controller
    {
        private readonly IBudgetRepository _budgetRepository;

        public BudgetController(IBudgetRepository budgetRepository)
        {
            _budgetRepository = budgetRepository;
        }

        // GET: /Budget/

        public ActionResult Index()
        {
            var budgets = _budgetRepository.GetBudgets().ToList();
            return View(budgets);
        }

    }
}
