namespace Smart_Odoo.Models
{
    public class OverdueGrowthCustomerModel
    {
        public string Partner_Name { get; set; }

        public string Segment { get; set; }

        public decimal Paid_Ratio { get; set; }

        public decimal Overdue_Ratio { get; set; }

        public decimal Collection_Rate { get; set; }
    }
}