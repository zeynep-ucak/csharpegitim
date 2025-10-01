using System;

namespace FinancialCrmWeb.Models
{
    public class Spending
    {
        public int SpendingId { get; set; }
        public string SpendingTitle { get; set; } = null!;
        public decimal? SpendingAmount { get; set; }
        public DateTime? SpendingDate { get; set; }

       
        public int? CategoryId { get; set; }

        public Category? Category { get; set; }
    }
}
