namespace Smart_Odoo.Models
{
    public class HrDashboardViewModel
    {
        public HrKpiModel HrKpi { get; set; }

        public List<EmployeesByDepartmentModel>
            EmployeesByDepartment { get; set; }

        public List<EmployeeGrowthTrendModel>
            EmployeeGrowthTrend { get; set; }

        public List<EmployeeListModel>
            EmployeeList { get; set; }
    }
}
