using Smart_Odoo.Models;
using Smart_Odoo.Repository;

namespace Smart_Odoo.Service
{
    public class PurchaseService : IPurchaseService
    {
        private readonly IPurchaseRepository _repository;

        public PurchaseService(IPurchaseRepository repository)
        {
            _repository = repository;
        }

        public async Task<PurchaseDashboardViewModel> GetDashboardData()
        {
            return new PurchaseDashboardViewModel
            {
                PurchaseKpi =
                    await _repository.GetPurchaseKpi(),

                PendingApprovals =
                    await _repository.GetPendingApprovals(),

                SpendTrend =
                    await _repository.GetSpendTrend(),

                TopSuppliers =
                    await _repository.GetTopSuppliers(),

                RecentPurchaseOrders =
                    await _repository.GetRecentPurchaseOrders()
            };
        }

    }
}
