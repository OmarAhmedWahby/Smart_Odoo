using Smart_Odoo.Models;

namespace Smart_Odoo.Repository
{
    public interface IInventoryRepository
    {
        Task<InventoryKpiModel> GetInventoryKpis();

        Task<List<StockMovementTrendModel>>
            GetStockMovementTrend();

        Task<List<InventoryCategoryModel>>
            GetInventoryByCategory();

        Task<List<InventoryListModel>>
            GetInventoryList();
    }
}
