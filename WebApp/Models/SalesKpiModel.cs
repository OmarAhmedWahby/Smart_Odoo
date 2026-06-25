namespace Smart_Odoo.Models
{
    public class SalesKpiModel
    {
        public DateTime Month { get; set; }

        public decimal TotalSales { get; set; }
            
        public decimal? PrevMonthSales { get; set; }

        public decimal? MomGrowthPercent { get; set; }
    }
}
