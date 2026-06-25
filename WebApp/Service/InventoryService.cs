using Smart_Odoo.Models;
using Smart_Odoo.Repository;

namespace Smart_Odoo.Service
{
    public class InventoryService : IInventoryService
    {
        private readonly IInventoryRepository _repository;

        public InventoryService(IInventoryRepository repository)
        {
            _repository = repository;
        }
        public async Task<InventoryDashboardViewModel>
         GetDashboardData()
        {
            return new InventoryDashboardViewModel
            {
                InventoryKpis =
                    await _repository.GetInventoryKpis(),

                StockMovementTrend =
                    await _repository.GetStockMovementTrend(),

                InventoryByCategory =
                    await _repository.GetInventoryByCategory(),

                InventoryList =
                    await _repository.GetInventoryList()
            };
        }
    }
}
