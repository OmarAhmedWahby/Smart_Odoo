namespace Smart_Odoo.Models
{
    public class CrmDashboardViewModel
    {
        public CrmKpiSummaryModel KpiSummary { get; set; }

        public List<CrmCustomerGrowthModel>
            CustomerGrowth
        { get; set; }

        public List<CrmCustomerSegmentModel>
            CustomerSegments
        { get; set; }

        public List<CrmSalesPipelineModel>
            SalesPipeline
        { get; set; }

        public List<CrmCustomerListModel>
            CustomerList
        { get; set; }
    }
}
