using Dapper;
using Smart_Odoo.Models;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

namespace Smart_Odoo.Repository
{
    public class MlRepository : IMlRepository
    {
        private readonly DbConnectionFactory _factory;


        public MlRepository(DbConnectionFactory factory)
        {
            _factory = factory;
        }



        public async Task<List<InventoryStockoutPredictionModel>>
       GetInventoryStockoutPredictions()
        {
            using var connection =
                _factory.CreateConnection();


            string sql = @"
        SELECT *
        FROM smart_odoo.gold.vm_ml_inventory_stockout_prediction";


            var result =
                await connection
                .QueryAsync<InventoryStockoutPredictionModel>(sql);


            return result.ToList();
        }



        public async Task<List<InvoiceDelayScoringModel>>
            GetInvoiceDelayScores()
        {
            using var connection =
                _factory.CreateConnection();


            string sql = @"
        SELECT *
        FROM smart_odoo.gold.vm_ml_invoice_delay_scoring";


            var result =
                await connection
                .QueryAsync<InvoiceDelayScoringModel>(sql);


            return result.ToList();
        }



        public async Task<List<LeadScoreModel>>
            GetLeadScores()
        {
            using var connection =
                _factory.CreateConnection();


            string sql = @"
        SELECT *
        FROM smart_odoo.gold.vm_ml_leads_scores";


            var result =
                await connection
                .QueryAsync<LeadScoreModel>(sql);


            return result.ToList();
        }

        public async Task<SalesForecastResponseModel>
    GetSalesForecast(DateTime date)
        {
            using var client = new HttpClient();


            client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue(
                    "Bearer",
                    "dapi1213f8ceea27626008092645610d42cb"
                );


            var body = new
            {
                dataframe_records = new[]
                {
            new
            {
                ds = date.ToString("yyyy-MM-ddTHH:mm:ss")
            }
        }
            };


            var json =
                JsonSerializer.Serialize(body);


            var content =
                new StringContent(
                    json,
                    Encoding.UTF8,
                    "application/json"
                );


            var response =
                await client.PostAsync(
                "https://dbc-f88d29c6-4087.cloud.databricks.com/serving-endpoints/sales_forecasting_2_api/invocations",
                content);



            var result =
                await response.Content.ReadAsStringAsync();



            return JsonSerializer
                .Deserialize<SalesForecastResponseModel>(result);
        }

        public async Task<InventoryMovementResponseModel>
    PredictInventoryMovement(
    InventoryMovementRequestModel model)
        {

            using var client = new HttpClient();


            client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue(
                    "Bearer",
                    "dapi1213f8ceea27626008092645610d42cb"
                );



            var body = new
            {
                dataframe_split = new
                {
                    columns = new[]
                    {
                "inventory_age_days",
                "quantity_on_hand",
                "reserved_quantity",
                "unit_cost",
                "category",
                "warehouse_name"
            },


                    data = new[]
                    {
                new object[]
                {
                    model.Inventory_Age_Days,
                    model.Quantity_On_Hand,
                    model.Reserved_Quantity,
                    model.Unit_Cost,
                    model.Category,
                    model.Warehouse_Name
                }
            }
                }
            };



            var json =
                JsonSerializer.Serialize(body);



            var content =
                new StringContent(
                    json,
                    Encoding.UTF8,
                    "application/json"
                );



            var response =
                await client.PostAsync(
                "https://dbc-f88d29c6-4087.cloud.databricks.com/serving-endpoints/inventory_monement/invocations",
                content);



            var result =
                await response.Content.ReadAsStringAsync();



            return JsonSerializer
                .Deserialize<InventoryMovementResponseModel>(result);

        }
        public async Task<List<OverdueRiskCustomerModel>>
            GetOverdueRiskCustomers()
        {
            using var connection =
                _factory.CreateConnection();


            string sql = @"
        SELECT *
        FROM smart_odoo.gold.vm_ml_overdue_RiskCustomer";


            var result =
                await connection
                .QueryAsync<OverdueRiskCustomerModel>(sql);


            return result.ToList();
        }



        public async Task<List<OverdueGrowthCustomerModel>>
           GetOverdueGrowthCustomers()
        {
            using var connection =
                _factory.CreateConnection();


            string sql = @"
        SELECT *
        FROM smart_odoo.gold.vm_ml_overdue_GrowthCustomer";


            var result =
                await connection
                .QueryAsync<OverdueGrowthCustomerModel>(sql);


            return result.ToList();
        }
    }
}
