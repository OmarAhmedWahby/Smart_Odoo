using Smart_Odoo.Models;

namespace Smart_Odoo.Service
{
    public interface ICrmService
    {
        Task<CrmDashboardViewModel> GetDashboardData();

    }
}
