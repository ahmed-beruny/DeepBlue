using DeepBlue.Data;
using DeepBlue.Models;
using Microsoft.AspNetCore.Mvc;

namespace DeepBlue.Controllers
{
    public class PostController : Controller
    {
        private readonly Database _db;
        public PostController(Database db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<Posts> posts = _db.Posts.ToList();
            return View(posts);
        }
        public IActionResult Postss()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Postss(Posts it)
        {
            try
            {
                _db.Posts.Add(it);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception ex) {
                return View(it);
            }
        }
    }
}
