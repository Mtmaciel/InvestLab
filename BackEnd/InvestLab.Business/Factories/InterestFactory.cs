using InvestLab.Business.Services;
using InvestLab.Models.Interfaces;
using InvestLab.Models.Models;

namespace InvestLab.Business.Factories
{
    public static class InterestFactory
    {
        public static IInterest CreateInterest(Investiment investiment)
        {
            switch (investiment.InterestType)
            {
                case Models.Enums.InterestTypeEnum.PreFixed:
                case Models.Enums.InterestTypeEnum.IPCA:
                    return new IpcaService(investiment.Interest);
                default:
                    return new SelicService(investiment.Interest);
            }
        }
    }
}
