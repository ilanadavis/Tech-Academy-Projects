using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstChallenge.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var comic = FirstChallenge.Models.ComicBookManager.GetComicBooks();
            ViewBag.HeaderValue = "My Comics";
            return View();
        }
    }
}