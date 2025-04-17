using InvestLab.Models.BaseObjects;

namespace InvestLab.Business.Services
{
    public class IpcaService: Interest
    {
        public override decimal InterestValue { get; set; }
        public IpcaService(decimal interestRate)
        {
            InterestValue = GetIpca() + interestRate;
        }
        private decimal GetIpca()
        {
            // TODO: Implementar lógica de busca do IPCA por webservice
            return 5.06m;
        }
    }
}
