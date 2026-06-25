using Smart_Odoo.Models;
using Smart_Odoo.Repository;

namespace Smart_Odoo.Service
{
    public interface IDashboardSalesService
    {
        Task<DashboardSalesViewModel> GetDashboardData();

    }
}
