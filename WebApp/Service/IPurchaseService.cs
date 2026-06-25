using Smart_Odoo.Models;

namespace Smart_Odoo.Service
{
    public interface IPurchaseService
    {
        Task<PurchaseDashboardViewModel> GetDashboardData();
    }
}
