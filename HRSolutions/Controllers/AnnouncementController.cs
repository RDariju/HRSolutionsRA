using HRSolutions.Data;
using HRSolutions.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HRSolutions.Controllers
{
    public class AnnouncementController : Controller
    {
        int id = 0;
        private readonly ApplicationDbContext _context;
        public AnnouncementController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            // Fetch announcements for the dashboard
            var announcements = await _context.Announcement.ToListAsync();
            return View(announcements);
        }

        [HttpGet]
        public IActionResult AddAnnouncement()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddAnnouncement(Announcement announcement)
        {
            id++;
            var announcements = new Announcement
            {
                announcementId =id.ToString(),
                announcementTitle = announcement.announcementTitle,
                description = announcement.description
            };

            // Do NOT set NoticeId here
            _context.Announcement.Add(announcements);
            await _context.SaveChangesAsync();
            return RedirectToAction("AddAnnouncement");
        }
    }
}
