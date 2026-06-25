using Smart_Odoo.Models;

namespace Smart_Odoo.Service
{
    public interface IMlService
    {
        Task<MlDashboardViewModel>
      GetDashboardData();



        Task<SalesForecastResponseModel>
            GetSalesForecast(DateTime date);



        Task<InventoryMovementResponseModel>
            PredictInventoryMovement(
            InventoryMovementRequestModel model);
    }
}
