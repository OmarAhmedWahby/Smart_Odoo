using Smart_Odoo.Models;
using Smart_Odoo.Repository;

namespace Smart_Odoo.Service
{
    public class MlService : IMlService
    {

        private readonly IMlRepository _repository;



        public MlService(IMlRepository repository)
        {
            _repository = repository;
        }



        public async Task<MlDashboardViewModel>
            GetDashboardData()
        {

            var riskTask =
                _repository.GetOverdueRiskCustomers();


            var growthTask =
                _repository.GetOverdueGrowthCustomers();


            var invoiceTask =
                _repository.GetInvoiceDelayScores();


            var stockTask =
                _repository.GetInventoryStockoutPredictions();


            var leadTask =
                _repository.GetLeadScores();



            await Task.WhenAll(
                riskTask,
                growthTask,
                invoiceTask,
                stockTask,
                leadTask
            );



            return new MlDashboardViewModel
            {

                OverdueRiskCustomers =
                    await riskTask,


                OverdueGrowthCustomers =
                    await growthTask,


                InvoiceDelayScores =
                    await invoiceTask,


                InventoryStockoutPredictions =
                    await stockTask,


                LeadScores =
                    await leadTask

            };

        }



        public async Task<SalesForecastResponseModel>
            GetSalesForecast(DateTime date)
        {

            return await _repository
                .GetSalesForecast(date);

        }




        public async Task<InventoryMovementResponseModel>
            PredictInventoryMovement(
            InventoryMovementRequestModel model)
        {

            return await _repository
                .PredictInventoryMovement(model);

        }
    }
}
