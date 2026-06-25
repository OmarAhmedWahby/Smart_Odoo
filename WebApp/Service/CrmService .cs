using Smart_Odoo.Models;
using Smart_Odoo.Repository;

namespace Smart_Odoo.Service
{
    public class CrmService : ICrmService
    {
        private readonly ICrmRepository _repository;

        public CrmService(ICrmRepository repository)
        {
            _repository = repository;
        }

        public async Task<CrmDashboardViewModel>
           GetDashboardData()
        {
            return new CrmDashboardViewModel
            {
                KpiSummary =
                    await _repository.GetKpiSummary(),

                CustomerGrowth =
                    await _repository.GetCustomerGrowth(),

                CustomerSegments =
                    await _repository.GetCustomerSegments(),

                SalesPipeline =
                    await _repository.GetSalesPipeline(),

                CustomerList =
                    await _repository.GetCustomerList()
            };
        }
    }
}
