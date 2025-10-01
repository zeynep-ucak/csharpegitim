using FinancialCrmWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinancialCrmWeb.Controllers
{
    public class AccountController : Controller
    {
        private readonly FinancialCrmContext _context;

        public AccountController(FinancialCrmContext context)
        {
            _context = context;
        }


        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

      
        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            var user = _context.Users.FirstOrDefault(u => u.Username == username && u.Password == password);
            if (user != null)
            {
                
                HttpContext.Session.SetString("username", username);
                return RedirectToAction("Index", "Dashboard");
            }

            ViewBag.Error = "Kullanıcı adı veya şifre hatalı!";
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
    }
}
