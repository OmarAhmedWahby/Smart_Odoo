using Dapper;
using Smart_Odoo.Models;

namespace Smart_Odoo.Repository
{
    public class PurchaseRepository : IPurchaseRepository
    {
        private readonly DbConnectionFactory _factory;

        public PurchaseRepository(DbConnectionFactory factory)
        {
            _factory = factory;
        }

        public async Task<PurchaseKpiModel> GetPurchaseKpi()
        {
            using var connection = _factory.CreateConnection();

            string sql = @"
                SELECT *
                FROM smart_odoo.gold.vw_purchase_kpis
                ORDER BY month DESC
                LIMIT 1";

            return await connection
                .QueryFirstOrDefaultAsync<PurchaseKpiModel>(sql);
        }

        public async Task<PendingApprovalModel> GetPendingApprovals()
        {
            using var connection = _factory.CreateConnection();

            string sql = @"
                SELECT *
                FROM smart_odoo.gold.vw_pending_purchase_approvals";

            return await connection
                .QueryFirstOrDefaultAsync<PendingApprovalModel>(sql);
        }

        public async Task<List<PurchaseSpendTrendModel>> GetSpendTrend()
        {
            using var connection = _factory.CreateConnection();

            string sql = @"
                SELECT *
                FROM smart_odoo.gold.vw_purchase_spend_trend
                ORDER BY month_number ASC";

            var result =
                await connection.QueryAsync<PurchaseSpendTrendModel>(sql);

            return result.ToList();
        }

        public async Task<List<TopSupplierModel>> GetTopSuppliers()
        {
            using var connection = _factory.CreateConnection();

            string sql = @"
                SELECT *
                FROM smart_odoo.gold.vw_top_suppliers_orders
                ORDER BY total_orders DESC
                LIMIT 5";

            var result =
                await connection.QueryAsync<TopSupplierModel>(sql);

            return result.ToList();
        }

        public async Task<List<RecentPurchaseOrderModel>> GetRecentPurchaseOrders()
        {
            using var connection = _factory.CreateConnection();

            string sql = @"
                SELECT *
                FROM smart_odoo.gold.vw_recent_purchase_orders
                LIMIT 5";

            var result =
                await connection.QueryAsync<RecentPurchaseOrderModel>(sql);

            return result.ToList();
        }

    }
}
