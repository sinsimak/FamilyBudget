namespace FamilyBudgetDAL.DomainClasses
{
    public class Payment
    {
        public int Id { get; set; }
        public PaymentType PaymentType { get; set; }
        public string Description { get; set; }
        public decimal PlannedAmount { get; set; }
        public decimal SpentAmount { get; set; }
        public Budget Budget { get; set; }
    }
}
