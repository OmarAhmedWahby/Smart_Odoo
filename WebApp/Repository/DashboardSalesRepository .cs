using Dapper;
using Smart_Odoo.Models;

namespace Smart_Odoo.Repository
{
    public class DashboardSalesRepository : IDashboardSalesRepository
    {
        private readonly DbConnectionFactory _factory;

        public DashboardSalesRepository(DbConnectionFactory factory)
        {
            _factory = factory;
        }

        public async Task<SalesKpiModel> GetSalesKpi()
        {
            using var connection = _factory.CreateConnection();

            string sql = @"
                SELECT *
                FROM smart_odoo.gold.vw_monthly_sales_mom
                ORDER BY month DESC
                LIMIT 1";

            return await connection.QueryFirstOrDefaultAsync<SalesKpiModel>(sql);
        }

        public async Task<OrdersKpiModel> GetOrdersKpi()
        {
            using var connection = _factory.CreateConnection();

            string sql = @"
                SELECT *
                FROM smart_odoo.gold.vw_monthly_orders_mom
                ORDER BY month DESC
                LIMIT 1";

            return await connection.QueryFirstOrDefaultAsync<OrdersKpiModel>(sql);
        }

        public async Task<AovKpiModel> GetAovKpi()
        {
            using var connection = _factory.CreateConnection();

            string sql = @"
                SELECT *
                FROM smart_odoo.gold.vw_monthly_aov_mom
                ORDER BY month DESC
                LIMIT 1";

            return await connection.QueryFirstOrDefaultAsync<AovKpiModel>(sql);
        }

        public async Task<CustomerKpiModel> GetCustomerKpi()
        {
            using var connection = _factory.CreateConnection();

            string sql = @"
                SELECT *
                FROM smart_odoo.gold.vw_monthly_customer_kpis
                ORDER BY month DESC
                LIMIT 1";

            return await connection.QueryFirstOrDefaultAsync<CustomerKpiModel>(sql);
        }

        public async Task<List<RevenueTrendModel>> GetRevenueTrend()
        {
            using var connection = _factory.CreateConnection();

            string sql = @"
                SELECT *
                FROM smart_odoo.gold.vw_sales_revenue_trend
                ORDER BY month_number ASC";

            var result =
                await connection.QueryAsync<RevenueTrendModel>(sql);

            return result.ToList();
        }

        public async Task<List<TopProductModel>> GetTopProducts()
        {
            using var connection = _factory.CreateConnection();

            string sql = @"
                SELECT *
                FROM smart_odoo.gold.vw_top_products_sales
                ORDER BY total_sales DESC
                LIMIT 5";

            var result =
                await connection.QueryAsync<TopProductModel>(sql);

            return result.ToList();
        }

        public async Task<List<RecentOrderModel>> GetRecentOrders()
        {
            using var connection = _factory.CreateConnection();

            string sql = @"
                SELECT *
                FROM smart_odoo.gold.vw_recent_orders
                ORDER BY order_date DESC
                LIMIT 5";

            var result =
                await connection.QueryAsync<RecentOrderModel>(sql);

            return result.ToList();
        }
    }
}
