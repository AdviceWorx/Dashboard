using Dashboard.Data;
using Dashboard.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Dashboard.Controllers
{
    public class ActivityController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ActivityController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: /
        // GET: /Activity
        public async Task<IActionResult> Index(DateTime? date)
        {
            var reportDate = date?.Date ?? DateTime.Today;

            var users = await _context.UserActivities
                .AsNoTracking()
                .Where(x => x.ReportDate.Date == reportDate)
                .OrderBy(x => x.UserName)
                .ToListAsync();

            var model = new ActivityDashboardViewModel
            {
                ReportDate = reportDate,
                Users = users
            };

            return View(model);
        }

        // GET: /Activity/User/1
        public async Task<IActionResult> User(int id)
        {
            var user = await _context.UserActivities
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == id);

            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }
    }
}