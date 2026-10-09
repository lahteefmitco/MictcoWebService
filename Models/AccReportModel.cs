namespace MictcoWebService.Models
{
    public class AccReportModel
    {
        public string StatementType { get; set; }
        public string fromDate { get; set; }
        public string toDate { get; set; }
        public string todayDate { get; set; }
        public int asId { get; set; }
        public int salesManId { get; set; }
        public int routeId { get; set; }
        public int Location { get; set; }
        public int customerId { get; set; }
        public int itemId { get; set; }
        public int ledgerId { get; set; }
        public int strId { get; set; }
        public int page { get; set; }
        public int pageSize { get; set; }
        public int agingdays { get; set; }
        public int type { get; set; }
        public bool groupSales { get; set; }
        public bool ledgerExcludePending { get; set; }
        public string search { get; set; }
        public string[] routeIds { get; set; }
        public string[] salesmanIds { get; set; }
        public InsightModel Insight { get; set; }
        public CashFlowModel CashFlow { get; set; }
        public IncomeExpenseModel IncomeExpense { get; set; }
    }
}
