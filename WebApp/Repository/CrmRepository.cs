using Dapper;
using Smart_Odoo.Models;

namespace Smart_Odoo.Repository
{
    public class CrmRepository : ICrmRepository
    {
        private readonly DbConnectionFactory _factory;

        public CrmRepository(DbConnectionFactory factory)
        {
            _factory = factory;
        }

        public async Task<CrmKpiSummaryModel> GetKpiSummary()
        {
            using var connection = _factory.CreateConnection();

            string sql = @"
                SELECT *
                FROM smart_odoo.gold.vw_crm_kpi_summary";

            return await connection
                .QueryFirstOrDefaultAsync<CrmKpiSummaryModel>(sql);
        }

        public async Task<List<CrmCustomerGrowthModel>>
            GetCustomerGrowth()
        {
            using var connection = _factory.CreateConnection();

            string sql = @"
                SELECT *
                FROM smart_odoo.gold.vw_crm_customer_growth";

            var result =
                await connection
                    .QueryAsync<CrmCustomerGrowthModel>(sql);

            return result.ToList();
        }

        public async Task<List<CrmCustomerSegmentModel>>
            GetCustomerSegments()
        {
            using var connection = _factory.CreateConnection();

            string sql = @"
                SELECT *
                FROM smart_odoo.gold.vw_crm_customer_segments";

            var result =
                await connection
                    .QueryAsync<CrmCustomerSegmentModel>(sql);

            return result.ToList();
        }

        public async Task<List<CrmSalesPipelineModel>>
            GetSalesPipeline()
        {
            using var connection = _factory.CreateConnection();

            string sql = @"
                SELECT *
                FROM smart_odoo.gold.vw_crm_sales_pipeline";

            var result =
                await connection
                    .QueryAsync<CrmSalesPipelineModel>(sql);

            return result.ToList();
        }

        public async Task<List<CrmCustomerListModel>>
            GetCustomerList()
        {
            using var connection = _factory.CreateConnection();

            string sql = @"
                SELECT *
                FROM smart_odoo.gold.vw_crm_customer_list";

            var result =
                await connection
                    .QueryAsync<CrmCustomerListModel>(sql);

            return result.ToList();
        }
    }
}
