namespace InvestLab.Models.Interfaces
{
    public interface IInterest
    {
        decimal InterestValue { get; set; }
        public decimal GetAnualInterest();
        public decimal GetMonthlyInterest();
    }
}
