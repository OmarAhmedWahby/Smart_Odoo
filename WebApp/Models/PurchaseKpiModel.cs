namespace Smart_Odoo.Models
{
    public class PurchaseKpiModel
    {
        public DateTime Month { get; set; }

        public int TotalOrders { get; set; }

        public decimal OrdersGrowthPercent { get; set; }

        public decimal TotalSpend { get; set; }

        public decimal SpendGrowthPercent { get; set; }

        public int ActiveSuppliers { get; set; }

        public int NewSuppliersThisMonth { get; set; }
    }
}
