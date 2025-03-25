using InvestLab.Models.Models;

namespace InvestLab.Business
{
    public class RendaFixa
    {
        public Investimento Invest { get; set; }
        public RendaFixa(Investimento invest)
        {
            Invest = invest;
        }
    }
}
