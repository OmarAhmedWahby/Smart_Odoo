namespace Smart_Odoo.Models
{
    public class InventoryListModel
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public string ProductSku { get; set; }

        public string Category { get; set; }

        public decimal QuantityOnHand { get; set; }

        public decimal AvailableQuantity { get; set; }

        public decimal UnitPrice { get; set; }

        public decimal UnitCost { get; set; }

        public decimal TotalStockValue { get; set; }

        public string Status { get; set; }
    }
}
