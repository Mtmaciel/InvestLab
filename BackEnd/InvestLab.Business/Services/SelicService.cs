using InvestLab.Models.BaseObjects;

namespace InvestLab.Business.Services
{
    public class SelicService : Interest
    {
        public override decimal InterestValue { get; set; }

        public SelicService(decimal interestRate)
        {
            InterestValue = GetSelic()*(interestRate/100);
        }

        private decimal GetSelic()
        {
            return 14.25m;
        }

    }
}
