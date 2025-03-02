using System.Diagnostics;
using HRSolutions.Models;
using Microsoft.AspNetCore.Mvc;

namespace HRSolutions.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return PartialView(); 
        }

        public IActionResult HRanalytics()
        {
            return PartialView();
        }
        public IActionResult newEmployee()
        {
            return PartialView();
        }
        public IActionResult viewEmployee()
        {
            return PartialView();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
