using InvestLab.Models.Enums;

namespace InvestLab.Models.Models
{
    public class Investiment
    {
        public DateTime DueDate { get; set; }
        public bool ConsiderIncomeTax { get; set; }
        public InterestTypeEnum InterestType { get; set; }
        public decimal Interest { get; set; }
        public decimal InitialBudget { get; set; }
        public decimal MonthlyBudget { get; set; }
    }
}
