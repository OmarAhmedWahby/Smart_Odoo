namespace Smart_Odoo.Models
{
    public class OrdersKpiModel
    {
        public DateTime Month { get; set; }

        public int TotalOrders { get; set; }

        public int? PrevMonthOrders { get; set; }

        public decimal? MomGrowthPercent { get; set; }
    }
}
