using Dapper;
using Smart_Odoo.Models;

namespace Smart_Odoo.Repository
{
    public class InventoryRepository : IInventoryRepository
    {
        private readonly DbConnectionFactory _factory;

        public InventoryRepository(DbConnectionFactory factory)
        {
            _factory = factory;
        }
        public async Task<InventoryKpiModel> GetInventoryKpis()
        {
            using var connection = _factory.CreateConnection();

            string sql = @"
                SELECT *
                FROM smart_odoo.gold.vw_inventory_kpis";

            return await connection
                .QueryFirstOrDefaultAsync<InventoryKpiModel>(sql);
        }

        public async Task<List<StockMovementTrendModel>>
            GetStockMovementTrend()
        {
            using var connection = _factory.CreateConnection();

            string sql = @"
                SELECT *
                FROM smart_odoo.gold.vw_stock_movement_trend";

            var result =
                await connection
                    .QueryAsync<StockMovementTrendModel>(sql);

            return result.ToList();
        }

        public async Task<List<InventoryCategoryModel>>
            GetInventoryByCategory()
        {
            using var connection = _factory.CreateConnection();

            string sql = @"
                SELECT *
                FROM smart_odoo.gold.vw_inventory_by_category";

            var result =
                await connection
                    .QueryAsync<InventoryCategoryModel>(sql);

            return result.ToList();
        }

        public async Task<List<InventoryListModel>>
            GetInventoryList()
        {
            using var connection = _factory.CreateConnection();

            string sql = @"
                SELECT *
                FROM smart_odoo.gold.vw_inventory_list";

            var result =
                await connection
                    .QueryAsync<InventoryListModel>(sql);

            return result.ToList();
        }
    }
}
