using System.Collections.Generic;

namespace FinancialCrmWeb.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = null!;

        
        public ICollection<Spending> Spendings { get; set; } = new List<Spending>();
    }
}
