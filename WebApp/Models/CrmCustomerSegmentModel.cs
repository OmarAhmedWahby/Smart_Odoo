namespace Smart_Odoo.Models
{
    public class CrmCustomerSegmentModel
    {
        public string Segment { get; set; }

        public int TotalCustomers { get; set; }

        public decimal TotalRevenue { get; set; }

        public decimal AvgOrdersPerCustomer { get; set; }
    }
}
