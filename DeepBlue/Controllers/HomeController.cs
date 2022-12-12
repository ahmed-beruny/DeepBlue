using DeepBlue.Data;
using DeepBlue.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DeepBlue.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Database _db;

        public HomeController(ILogger<HomeController> logger,Database db)
        {
            _logger = logger;
            _db = db;   
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Members()
        {
            List<Members> members = _db.Members.ToList();
            return View(members);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}