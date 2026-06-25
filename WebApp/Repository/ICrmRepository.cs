using Smart_Odoo.Models;

namespace Smart_Odoo.Repository
{
    public interface ICrmRepository
    {
        Task<CrmKpiSummaryModel> GetKpiSummary();

        Task<List<CrmCustomerGrowthModel>>
            GetCustomerGrowth();

        Task<List<CrmCustomerSegmentModel>>
            GetCustomerSegments();

        Task<List<CrmSalesPipelineModel>>
            GetSalesPipeline();

        Task<List<CrmCustomerListModel>>
            GetCustomerList();
    }
}
