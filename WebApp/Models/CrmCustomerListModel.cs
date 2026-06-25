namespace Smart_Odoo.Models
{
    public class CrmCustomerListModel
    {
        public int CustomerId { get; set; }

        public string CustomerName { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Status { get; set; }

        public int TotalOrders { get; set; }

        public decimal TotalValue { get; set; }

        public DateTime? LastOrderDate { get; set; }

        public DateTime? FirstOrderDate { get; set; }

        public int TotalDeals { get; set; }

        public int OpenDeals { get; set; }

        public decimal PipelineValue { get; set; }

        public int CustomerRank { get; set; }

        public bool IsCompany { get; set; }
    }
}
