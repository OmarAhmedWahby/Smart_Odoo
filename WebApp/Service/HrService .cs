using Smart_Odoo.Models;
using Smart_Odoo.Repository;

namespace Smart_Odoo.Service
{
    public class HrService : IHrService
    {
        private readonly IHrRepository _repository;

        public HrService(IHrRepository repository)
        {
            _repository = repository;
        }

        public async Task<HrDashboardViewModel> GetDashboardData()
        {
            return new HrDashboardViewModel
            {
                HrKpi =
                    await _repository.GetHrKpis(),

                EmployeesByDepartment =
                    await _repository.GetEmployeesByDepartment(),

                EmployeeGrowthTrend =
                    await _repository.GetEmployeeGrowthTrend(),

                EmployeeList =
                    await _repository.GetEmployeeList()
            };
        }
    }
}
