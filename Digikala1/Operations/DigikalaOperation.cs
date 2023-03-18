using Digikala1.Model;

namespace Digikala1.Operations
{
     class DigikalaOperation
    {
        List<Digikala> digikalas;
        public DigikalaOperation(List<Digikala> digikalas)
        {
            this.digikalas = digikalas;
        }
        public List<Digikala> SearchByUser(int ID_Customer)
        {
            return digikalas
                 .Where(x => x.ID_Customer == ID_Customer)
                 .ToList();
        }
/*        public List<int> AllSalesByYear(int year)
        {
            return digikalas.
             Where(x => x.DateTime_CartFinalize == year)
             .Select(x => x.Amount_Gross_Order)
             .ToList();
        }
        public long SumSalesByYear(int year)
        {
            List<int> sales = AllSalesByYear(year);
            long total = 0;

            foreach (int sale in sales)
            {
                total += sale;
            }

            return total;
        }*/
    }
}
