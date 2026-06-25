using Smart_Odoo.Models;

namespace Smart_Odoo.Repository
{
    public interface IDashboardSalesRepository
    {
        Task<SalesKpiModel> GetSalesKpi();

        Task<OrdersKpiModel> GetOrdersKpi();

        Task<AovKpiModel> GetAovKpi();

        Task<CustomerKpiModel> GetCustomerKpi();

        Task<List<RevenueTrendModel>> GetRevenueTrend();

        Task<List<TopProductModel>> GetTopProducts();

        Task<List<RecentOrderModel>> GetRecentOrders();
    }
}
