using InvestLab.Models.Interfaces;

namespace InvestLab.Models.BaseObjects
{
    public abstract class Interest : IInterest
    {
        public abstract decimal InterestValue { get; set; }

        public decimal GetAnualInterest()
        {
            return InterestValue;
        }

        public decimal GetMonthlyInterest()
        {
            return InterestValue / 12;
        }
    }
}
