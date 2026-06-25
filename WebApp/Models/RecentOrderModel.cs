namespace Smart_Odoo.Models
{
    public class RecentOrderModel
    {
        public string OrderId { get; set; }

        public string CustomerName { get; set; }

        public int ItemsCount { get; set; }

        public decimal OrderAmount { get; set; }

        public string OrderState { get; set; }

        public DateTime OrderDate { get; set; }
    }
}
