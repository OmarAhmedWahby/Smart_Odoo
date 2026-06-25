namespace Smart_Odoo.Models
{
    public class CrmKpiSummaryModel
    {
        public int TotalCustomers { get; set; }

        public int CustomersAddedThisMonth { get; set; }

        public int ActiveDeals { get; set; }

        public decimal TotalDealValue { get; set; }

        public decimal LastMonthDealValue { get; set; }

        public decimal DealValuePctChange { get; set; }

        public decimal ConversionRatePct { get; set; }

        public decimal LastMonthConversionRatePct { get; set; }

        public decimal ConversionRateChange { get; set; }
    }
}
