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
        public List<int> SearchBYID_ORDER(int ID_Order)
        {
            return digikalas
                 .Where(x => x.ID_Order == ID_Order)
                 .Select(x => x.Amount_Gross_Order)
                 .ToList();
        }
        public long priceSalesByorder(int ID_Order)
        {
            List<int> sales = SearchBYID_ORDER(ID_Order);
            long total = 0;

            foreach (int sale in sales)
            {
                total += sale;
            }

            return total;
        }
        public List<int> AllSalesBycustomer(int ID_Customer)
        {
            return digikalas
             .Where(x => x.ID_Customer == ID_Customer)
             .Select(x => x.Amount_Gross_Order)
             .ToList();
        }
        public long SumSalesBycustomer(int ID_Customer)
        {
            List<int> sales = AllSalesBycustomer(ID_Customer);
            long total = 0;

            foreach (int sale in sales)
            {
                total += sale;
            }

            return total;
        }
        public List<int> AllSalesBYID_item(int ID_Item)
        {
            return digikalas
                 .Where(x => x.ID_Item == ID_Item)
                 .Select(x => x.Amount_Gross_Order)
                 .ToList();
        }
        public long sumSalesByitem(int ID_Item)
        {
            List<int> sales = AllSalesBYID_item(ID_Item);
            long total = 0;

            foreach (int sale in sales)
            {
                total += sale;
            }

            return total;
        }
        public List<int> AllSalesByYear(int year)
        {
            return digikalas
             .Where(x => x.DateTime_CartFinalize.Year == year)
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
        }
        public List<int> AllSalesBycity_name(string city_name_fa)
        {
            return digikalas
             .Where(x => x.city_name_fa == city_name_fa.ToString())
             .Select(x => x.Amount_Gross_Order)
             .ToList();
        }
        public long SumSalescity_name(int city_name_fa)
        {
            List<int> sales = AllSalesBycity_name(city_name_fa.ToString());
            long total = 0;

            foreach (int sale in sales)
            {
                total += sale;
            }

            return total;
        }
    }
}
