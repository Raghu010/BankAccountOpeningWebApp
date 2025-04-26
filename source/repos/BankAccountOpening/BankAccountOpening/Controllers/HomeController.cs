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
            var users = _context.Users.ToList();
            return View(users);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var model = new UserDetails();
            var stateNames = _context.states.ToList();
            ViewBag.States = new SelectList(stateNames, "StateId", "StateName");

            var cityNames = _context.cities.ToList();
            ViewBag.CityNames = new SelectList(cityNames, "CityId", "CityName");

            var branchNames = _context.branches.ToList();
            ViewBag.BranchNames = new SelectList(branchNames, "BranchCode", "BranchName");

            var languageNames = _context.languages.ToList();
            ViewBag.LanguageNames = new SelectList(languageNames, "LanguageCode", "LanguageName");
            return View(model);
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
