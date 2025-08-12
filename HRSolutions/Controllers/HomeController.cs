using System.Diagnostics;
using HRSolutions.Data;
using HRSolutions.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HRSolutions.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var notices = _context.Notice.ToList();
            var announcements = _context.Announcement.ToList();

            var viewModel = new View
            {
                Notices = notices,
                Announcements = announcements
            };

            return PartialView(viewModel);
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
        public IActionResult AddNotice()
        {
            return PartialView();
        }
        public IActionResult AddAnnouncement()
        {
            return PartialView();
        }
        public IActionResult CheckinCheckout()
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
