using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstChallenge.Models;

namespace FirstChallenge.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var comic = ComicBookManager.GetComicBooks();
            ViewBag.HeaderValue = "My Comics";
            return View(comic);
        }

        public ActionResult Detail(int id)
        {
            var comic = ComicBookManager.GetComicBooks();
            var comics = comic.FirstOrDefault(p => p.ComicBookId == id);
            return View(comics);
        }
    }

}