using Smart_Odoo.Models;
using Smart_Odoo.Repository;

namespace Smart_Odoo.Service
{
    public class DashboardSalesService : IDashboardSalesService
    {
        private readonly IDashboardSalesRepository _repository;

        public DashboardSalesService(IDashboardSalesRepository repository)
        {
            _repository = repository;
        }

        public async Task<DashboardSalesViewModel> GetDashboardData()
        {
            return new DashboardSalesViewModel
            {
                SalesKpi = await _repository.GetSalesKpi(),

                OrdersKpi = await _repository.GetOrdersKpi(),

                AovKpi = await _repository.GetAovKpi(),

                CustomerKpi = await _repository.GetCustomerKpi(),

                RevenueTrend = await _repository.GetRevenueTrend(),

                TopProducts = await _repository.GetTopProducts(),

                RecentOrders = await _repository.GetRecentOrders()
            };
        }
    }
}
