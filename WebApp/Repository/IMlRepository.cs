using Smart_Odoo.Models;

namespace Smart_Odoo.Repository
{
    public interface IMlRepository
    {

        Task<List<OverdueRiskCustomerModel>>
            GetOverdueRiskCustomers();



        Task<List<OverdueGrowthCustomerModel>>
            GetOverdueGrowthCustomers();



        Task<List<InvoiceDelayScoringModel>>
            GetInvoiceDelayScores();



        Task<List<InventoryStockoutPredictionModel>>
            GetInventoryStockoutPredictions();



        Task<List<LeadScoreModel>>
            GetLeadScores();



        Task<SalesForecastResponseModel>
            GetSalesForecast(DateTime date);



        Task<InventoryMovementResponseModel>
            PredictInventoryMovement(
            InventoryMovementRequestModel model);

    }
}