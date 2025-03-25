namespace InvestLab.Business.Services
{
    public class IpcaService
    {
        public decimal IpcaValue { get; set; }
        public decimal GetIpca()
        {
            if (IpcaValue == 0)
            {
                IpcaValue = 5.06m;
                return 0;
            }
            else
            {
                return IpcaValue;
            }
        }
    }
}
