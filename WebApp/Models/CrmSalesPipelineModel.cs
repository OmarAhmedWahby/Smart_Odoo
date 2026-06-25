namespace Smart_Odoo.Models
{
    public class CrmSalesPipelineModel
    {
        public int StageId { get; set; }

        public string StageName { get; set; }

        public int DealCount { get; set; }

        public decimal TotalExpectedRevenue { get; set; }

        public decimal AvgProbability { get; set; }

        public decimal AvgDaysInStage { get; set; }
    }
}
