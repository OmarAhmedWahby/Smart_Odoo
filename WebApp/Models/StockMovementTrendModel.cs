namespace Smart_Odoo.Models
{
    public class StockMovementTrendModel
    {
        public string MonthName { get; set; }
        public int YearNumber { get; set; }
        public int MonthNumber { get; set; }
        public decimal InboundQty { get; set; }
        public decimal OutboundQty { get; set; }
        public decimal NetMovement { get; set; }
        public decimal InboundValue { get; set; }
        public decimal OutboundValue { get; set; }
        public decimal NetValue { get; set; }
    }
}
