namespace Smart_Odoo.Models
{
    public class RecentPurchaseOrderModel
    {
        public string PurchaseOrderId { get; set; }

        public string SupplierName { get; set; }

        public int ItemsCount { get; set; }

        public decimal OrderAmount { get; set; }

        public string PurchaseStatus { get; set; }

        public DateTime PurchaseDate { get; set; }
    }
}
