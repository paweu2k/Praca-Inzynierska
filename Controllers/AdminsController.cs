using Microsoft.AspNetCore.Mvc;
using Praca_Inżynierska.Data;
using System.Linq;
using Praca_Inżynierska.Models.Domain;
using System;

namespace Praca_Inżynierska.Controllers
{
    public class AdminsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        private readonly InzDbContext _context;
        public AdminsController(InzDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult VerifyLogin(string username, string password)
        {
            var user = _context.Users.FirstOrDefault(u => u.login == username && u.haslo == password && u.czy_admin == "tak");

            if (user != null)
            {
                return Json(new { success = true });
            }
            else
            {
                return Json(new { success = false });
            }
        }
    }
}
