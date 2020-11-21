using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using cinepolicial.Models;

namespace cinepolicial.Controllers
{
    public class CineController : Controller
    {
        readonly CineDbConnection db = new CineDbConnection();
        // GET: Cine
        public ActionResult Index()
        {
            var cines = db.Cines.ToList();
            return View(cines);
        }
    }
}