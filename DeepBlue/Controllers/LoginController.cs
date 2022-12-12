using DeepBlue.Data;
using DeepBlue.Models;
using Microsoft.AspNetCore.Mvc;

namespace DeepBlue.Controllers
{
    public class LoginController : Controller
    {
        private readonly Database _db;
        public LoginController(Database db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignUp(Members it)
        {
            try
            {
                _db.Members.Add(it);
                _db.SaveChanges();
                return RedirectToAction("Index","Home");
            }
            catch (Exception ex)
            {
                return View(it);
            }
        }


    }
}
