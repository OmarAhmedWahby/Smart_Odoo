namespace Smart_Odoo.Models
{
    public class InventoryDashboardViewModel
    {
        public InventoryKpiModel InventoryKpis { get; set; }

        public List<StockMovementTrendModel>
            StockMovementTrend
        { get; set; }

        public List<InventoryCategoryModel>
            InventoryByCategory
        { get; set; }

        public List<InventoryListModel>
            InventoryList
        { get; set; }
    }
}
