namespace Smart_Odoo.Models
{
    public class InventoryMovementRequestModel
        {
            public int Inventory_Age_Days { get; set; }

            public decimal Quantity_On_Hand { get; set; }

            public decimal Reserved_Quantity { get; set; }

            public decimal Unit_Cost { get; set; }

            public string Category { get; set; }

            public string Warehouse_Name { get; set; }
        }

}
