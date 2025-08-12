using HRSolutions.Data;
using HRSolutions.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HRSolutions.Controllers
{
    public class LoginController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LoginController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(Login login)
        {
            if (ModelState.IsValid)
            {
                var user = await _context.Login
                    .FirstOrDefaultAsync(u => u.UserName == login.UserName && u.Password == login.Password);

                if (user != null)
                {
                    // Optional: Set session or TempData here

                    // Redirect to homepage or dashboard
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ViewBag.Error = "Invalid username or password";
                    return View(login);
                }
            }

            return View(login);
        }
    }
}
