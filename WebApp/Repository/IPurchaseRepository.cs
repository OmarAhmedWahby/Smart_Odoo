using Smart_Odoo.Models;

namespace Smart_Odoo.Repository
{
    public interface IPurchaseRepository
    {
        Task<PurchaseKpiModel> GetPurchaseKpi();

        Task<PendingApprovalModel> GetPendingApprovals();

        Task<List<PurchaseSpendTrendModel>> GetSpendTrend();

        Task<List<TopSupplierModel>> GetTopSuppliers();

        Task<List<RecentPurchaseOrderModel>> GetRecentPurchaseOrders();
    }
}
