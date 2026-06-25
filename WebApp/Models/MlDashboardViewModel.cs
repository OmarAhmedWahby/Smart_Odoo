namespace Smart_Odoo.Models
{
    public class MlDashboardViewModel
    {

        public List<OverdueRiskCustomerModel>
            OverdueRiskCustomers
        { get; set; }



        public List<OverdueGrowthCustomerModel>
            OverdueGrowthCustomers
        { get; set; }



        public List<InvoiceDelayScoringModel>
            InvoiceDelayScores
        { get; set; }



        public List<InventoryStockoutPredictionModel>
            InventoryStockoutPredictions
        { get; set; }



        public List<LeadScoreModel>
            LeadScores
        { get; set; }



        public SalesForecastResponseModel
            SalesForecast
        { get; set; }



        public InventoryMovementResponseModel
            InventoryMovement
        { get; set; }

    }
}