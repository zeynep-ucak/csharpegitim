using FinancialCrmWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinancialCrmWeb.Controllers
{
    public class DashboardController : Controller
    {
        private readonly FinancialCrmContext _context;

        public DashboardController(FinancialCrmContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var totalBalance = _context.Banks.Sum(b => b.BankBalance) ?? 0;
            var lastProcess = _context.BankProcesses.OrderByDescending(p => p.ProcessDate).FirstOrDefault();
            var totalBills = _context.Bills.Sum(b => b.BillAmount) ?? 0;
            var totalSpendings = _context.Spendings.Sum(s => s.SpendingAmount) ?? 0;

            ViewBag.TotalBalance = totalBalance;
            ViewBag.LastProcess = lastProcess?.Description;
            ViewBag.TotalBills = totalBills;
            ViewBag.TotalSpendings = totalSpendings;

            return View();
        }
    }
}
