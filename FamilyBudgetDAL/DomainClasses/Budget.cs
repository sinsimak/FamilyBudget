using System;
using System.Collections.Generic;

namespace FamilyBudgetDAL.DomainClasses
{
    public class Budget
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<Payment> Payments { get; set; }
    }
}
