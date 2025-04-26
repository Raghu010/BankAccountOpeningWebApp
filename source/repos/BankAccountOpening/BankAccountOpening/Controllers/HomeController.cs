using BankAccountOpening.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;

namespace BankAccountOpening.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDBContext _context;

        public HomeController(ILogger<HomeController> logger, AppDBContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var today = DateTime.Today;

            var todaysRecords = _context.Users
                .Where(u => u.CreatedDate.Date == today)
                .ToList();

            return View(todaysRecords);
        }


        [HttpGet]
        public IActionResult Create()
        {
            int nextFormNumber = _context.Users.Max(u => (int?)u.FormNo ?? 0) + 1;
            var model = new UserDetails
            {
                FormNo = nextFormNumber
            };

            var stateNames = _context.states.ToList();
            ViewBag.States = new SelectList(_context.states.Select(x => x.StateName).ToList());

            var cityNames = _context.cities.ToList();
            ViewBag.CityNames = new SelectList(_context.cities.Select(x => x.CityName).ToList());

            var branchNames = _context.branches.ToList();
            ViewBag.BranchNames = new SelectList(_context.branches.Select(x => x.BranchName).ToList());

            var languageNames = _context.languages.ToList();
            ViewBag.LanguageNames = new SelectList(_context.languages.Select(x => x.languageName).ToList());

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(UserDetails userData)
        {
            userData.CreatedDate = DateTime.Now;
            _context.Users.Add(userData);
            _context.SaveChanges();
            return RedirectToAction("Index", new { FormNo = userData.FormNo });
        }

        public IActionResult Quit()
        {
            return Content("Application Closed.");
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
