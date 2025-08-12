using Microsoft.AspNetCore.Mvc;
using HRSolutions.Models;
using HRSolutions.Data;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace HRSolutions.Controllers
{
    public class NoticeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public NoticeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var notices = await _context.Notice.ToListAsync();
            return View(notices);
        }

        [HttpGet]
        public IActionResult AddNotice()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddNotice(Notice notice)
        {
            var notices = new Notice
            {
                Title = notice.Title,
                Auther = notice.Auther,
                Description = notice.Description
            };

            // Do NOT set NoticeId here
            _context.Notice.Add(notices);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

       
    }
}
