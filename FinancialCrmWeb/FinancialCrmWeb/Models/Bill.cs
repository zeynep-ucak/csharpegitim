namespace FinancialCrmWeb.Models
{
    public class Bill
    {
        public int BillId { get; set; }
        public string BillTitle { get; set; } = null!;
        public decimal? BillAmount { get; set; }
        public string BillPeriod { get; set; } = null!;
    }
}
