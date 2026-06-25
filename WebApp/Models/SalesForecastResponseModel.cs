namespace Smart_Odoo.Models
{
    public class SalesForecastResponseModel
        {
            public decimal Yhat { get; set; }

            public decimal Yhat_lower { get; set; }

            public decimal Yhat_upper { get; set; }
        }

}
