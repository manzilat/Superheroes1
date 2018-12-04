using SuperHeroes1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SuperHeroes1.Controllers
{
    public class SuperHeroController : Controller
    {
        public ApplicationDbContext db = new ApplicationDbContext();
        // GET: SuperHero
        public ActionResult Index()
        {
            return View(db.SuperHero.ToList());
        }

        // GET: SuperHero/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
    }

}