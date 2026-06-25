namespace Smart_Odoo.Models
{
    public class PurchaseDashboardViewModel
    {
        public PurchaseKpiModel PurchaseKpi { get; set; }

        public PendingApprovalModel PendingApprovals { get; set; }

        public List<PurchaseSpendTrendModel> SpendTrend { get; set; }

        public List<TopSupplierModel> TopSuppliers { get; set; }

        public List<RecentPurchaseOrderModel> RecentPurchaseOrders { get; set; }
    }
}
