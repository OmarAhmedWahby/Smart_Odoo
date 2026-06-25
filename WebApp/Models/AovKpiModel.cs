namespace Smart_Odoo.Models
{
    public class AovKpiModel
    {
        public DateTime Month { get; set; }

        public decimal AvgOrderValue { get; set; }

        public decimal? PrevMonthAov { get; set; }

        public decimal? MomGrowthPercent { get; set; }
    }
}
