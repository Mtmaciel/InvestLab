namespace InvestLab.Business.Services
{
    public static class IncomeTaxService
    {
        private static decimal GetIncomeTax(DateTime dueDate)
        {
            var monthsDiference = (dueDate - DateTime.Now).Days;
            if (monthsDiference <= 180)
            {
                return 22.5m;
            }
            else if (monthsDiference <= 360)
            {
                return 20m;
            }
            else if (monthsDiference <= 720)
            {
                return 17.5m;
            }
            else
            {
                return 15m;
            }
        }

        public static decimal CalculateIncomeTax(DateTime dueDate)
        {
            var incomeTax = GetIncomeTax(dueDate);
            return (incomeTax / 100);
        }
    }
}
