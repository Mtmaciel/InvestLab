namespace InvestLab.Business.Services
{
    public class SelicService
    {
        public decimal SelicValue { get; set; }
        public decimal GetSelic()
        {
            if (SelicValue == 0)
            {
                SelicValue = 14.25m;
                return SelicValue;
            }
            else
            {
                return SelicValue;
            }
        }
    }
}
