using Dapper;
using Smart_Odoo.Models;

namespace Smart_Odoo.Repository
{
    public class HrRepository : IHrRepository
    {
        private readonly DbConnectionFactory _factory;

        public HrRepository(DbConnectionFactory factory)
        {
            _factory = factory;
        }

        public async Task<HrKpiModel> GetHrKpis()
        {
            using var connection = _factory.CreateConnection();

            string sql = @"
                SELECT *
                FROM smart_odoo.gold.vw_hr_kpis";

            return await connection
                .QueryFirstOrDefaultAsync<HrKpiModel>(sql);
        }

        public async Task<List<EmployeesByDepartmentModel>>
            GetEmployeesByDepartment()
        {
            using var connection = _factory.CreateConnection();

            string sql = @"
                SELECT *
                FROM smart_odoo.gold.vw_employee_by_field";

            var result =
                await connection
                    .QueryAsync<EmployeesByDepartmentModel>(sql);

            return result.ToList();
        }

        public async Task<List<EmployeeGrowthTrendModel>>
            GetEmployeeGrowthTrend()
        {
            using var connection = _factory.CreateConnection();

            string sql = @"
                SELECT *
                FROM smart_odoo.gold.vw_employee_growth_trend";

            var result =
                await connection
                    .QueryAsync<EmployeeGrowthTrendModel>(sql);

            return result.ToList();
        }

        public async Task<List<EmployeeListModel>>
            GetEmployeeList()
        {
            using var connection = _factory.CreateConnection();

            string sql = @"
                SELECT *
                FROM smart_odoo.gold.vw_employee_list";

            var result =
                await connection
                    .QueryAsync<EmployeeListModel>(sql);

            return result.ToList();
        }
    }

}
