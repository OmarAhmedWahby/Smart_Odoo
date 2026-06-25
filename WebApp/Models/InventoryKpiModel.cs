namespace Smart_Odoo.Models
{
    public class InventoryKpiModel
    {
        public int TotalItems { get; set; }

        public int ItemsAddedThisMonth { get; set; }

        public decimal TotalInventoryValue { get; set; }

        public decimal ValuePctChangeFromLastMonth { get; set; }

        public int LowStockItems { get; set; }

        public int ActiveCategories { get; set; }
    }
}
