namespace Smart_Odoo.Models
{
    public class InventoryStockoutPredictionModel
    {
        public int Product_Id { get; set; }

        public string Product_Name { get; set; }

        public decimal Available_Qty { get; set; }

        public decimal Days_Of_Stock { get; set; }

        public decimal Stockout_Probability { get; set; }

        public bool Will_Stockout { get; set; }

        public string Risk_Level { get; set; }
    }
    

}
