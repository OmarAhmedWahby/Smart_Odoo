namespace Smart_Odoo.Models
{
    public class DashboardSalesViewModel
    {
        public SalesKpiModel SalesKpi { get; set; }

        public OrdersKpiModel OrdersKpi { get; set; }

        public AovKpiModel AovKpi { get; set; }

        public CustomerKpiModel CustomerKpi { get; set; }

        public List<RevenueTrendModel> RevenueTrend { get; set; }

        public List<TopProductModel> TopProducts { get; set; }

        public List<RecentOrderModel> RecentOrders { get; set; }
    }
}
