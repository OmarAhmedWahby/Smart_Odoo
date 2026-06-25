using Smart_Odoo.Models;

namespace Smart_Odoo.Service
{
    public interface IInventoryService
    {
        Task<InventoryDashboardViewModel> GetDashboardData();

    }
}
