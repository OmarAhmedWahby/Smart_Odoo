using Smart_Odoo.Models;

namespace Smart_Odoo.Repository
{
    public interface IHrRepository
    {
        Task<HrKpiModel> GetHrKpis();

        Task<List<EmployeesByDepartmentModel>>
            GetEmployeesByDepartment();

        Task<List<EmployeeGrowthTrendModel>>
            GetEmployeeGrowthTrend();

        Task<List<EmployeeListModel>>
            GetEmployeeList();
    }
}
