namespace Smart_Odoo.Models
{
    public class InventoryCategoryModel
    {
        public string Category { get; set; }

        public int TotalProducts { get; set; }

        public decimal TotalQuantity { get; set; }

        public decimal TotalAvailableQuantity { get; set; }

        public decimal TotalStockValue { get; set; }

        public int TotalLocations { get; set; }
    }
}
