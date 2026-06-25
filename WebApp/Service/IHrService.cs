using Smart_Odoo.Models;

namespace Smart_Odoo.Service
{
    public interface IHrService
    {
        Task<HrDashboardViewModel> GetDashboardData();

    }
}
