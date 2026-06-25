namespace Smart_Odoo.Models
{
    public class LeadScoreModel
        {
            public int Lead_Id { get; set; }

            public string Lead_Name { get; set; }

            public decimal Probability_Of_Win { get; set; }

            public decimal Expected_Revenue { get; set; }

            public decimal Lead_Score { get; set; }
        }
    }
