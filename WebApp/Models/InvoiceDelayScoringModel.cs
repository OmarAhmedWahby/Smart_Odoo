namespace Smart_Odoo.Models
{
    public class InvoiceDelayScoringModel
    {
            public int Partner_Id { get; set; }

            public decimal Delay_Probability { get; set; }

            public string Risk_Bucket { get; set; }
        }

}
