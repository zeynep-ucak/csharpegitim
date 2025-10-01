using System.Collections.Generic;

namespace FinancialCrmWeb.Models
{
    public class Bank
    {
        public int BankId { get; set; }
        public string BankAccountNumber { get; set; } = null!;
        public string BankTitle { get; set; } = null!;
        public decimal? BankBalance { get; set; }

        // Navigation property
        public ICollection<BankProcess> BankProcesses { get; set; } = new List<BankProcess>();
    }
}
