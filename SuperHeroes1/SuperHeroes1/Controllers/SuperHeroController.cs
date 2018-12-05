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
        // GET: SuperHero/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SuperHero/Create
        [HttpPost]
        public ActionResult Create([Bind(Include = "SuperHeroName,AlterEgo,PrimarySuperHeroAbility,SecondarySuperHeroAbility,CatchPhrase")] SuperHero superHero)
        {

            db.SuperHero.Add(superHero);
            db.SaveChanges();
            return RedirectToAction("Index");

        }
        // GET: SuperHero/Edit/5
        public ActionResult Edit(int id)
        {
            SuperHero superHero = db.SuperHero.Find(id);
            return View(superHero);
        }

        // POST: SuperHero/Edit/5
        [HttpPost]
        public ActionResult Edit([Bind(Include = "SuperHeroName,AlterEgo,PrimarySuperHeroAbility,SecondarySuperHeroAbility,CatchPhrase")] SuperHero superHero, int id)
        {
            if (ModelState.IsValid)
            {
                SuperHero updatedSuperHero = db.SuperHero.Find(id);
                if (updatedSuperHero == null)
                {
                    return RedirectToAction("DisplayError", "SuperHero");
                }
                updatedSuperHero.SuperHeroName = superHero.SuperHeroName;
                updatedSuperHero.AlterEgo = superHero.AlterEgo;
                updatedSuperHero.PrimarySuperHeroAbility = superHero.PrimarySuperHeroAbility;
                updatedSuperHero.SecondarySuperHeroAbility = superHero.SecondarySuperHeroAbility;
                updatedSuperHero.Catchphrase = superHero.Catchphrase;
                db.Entry(updatedSuperHero).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(superHero);
        }

    }

}