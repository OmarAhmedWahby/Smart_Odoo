namespace Smart_Odoo.Models
{
    public class CrmCustomerGrowthModel
    {
        public string MonthName { get; set; }

        public int MonthNumber { get; set; }

        public int YearNumber { get; set; }

        public int NewCustomers { get; set; }

        public int CumulativeCustomers { get; set; }
    }
}
