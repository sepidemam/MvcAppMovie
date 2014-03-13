using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcAppMovie.Models;

namespace MvcAppMovie.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        MoviesDBEntities _db;

        public HomeController()
        {
            _db = new MoviesDBEntities();
        }


        public ActionResult Index()
        {
            ViewData.Model = _db.TableMovies;
            return View();
        }


        public ActionResult About()
        {
            return View();
        }
    }
}
