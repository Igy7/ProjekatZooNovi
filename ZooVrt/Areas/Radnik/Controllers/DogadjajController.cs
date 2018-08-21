using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ZooVrt.Entities;
using ZooVrt.Models;

namespace ZooVrt.Areas.Radnik.Controllers
{
    public class DogadjajController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Radnik/Dogadjaj
        public async Task<ActionResult> Index()
        {
            return View(await db.Dogadjaji.ToListAsync());
        }

        // GET: Radnik/Dogadjaj/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dogadjaj dogadjaj = await db.Dogadjaji.FindAsync(id);
            if (dogadjaj == null)
            {
                return HttpNotFound();
            }
            return View(dogadjaj);
        }

        // GET: Radnik/Dogadjaj/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Radnik/Dogadjaj/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "dogadjajId,naziv,datum,cenaKarte")] Dogadjaj dogadjaj)
        {
            if (ModelState.IsValid)
            {
                db.Dogadjaji.Add(dogadjaj);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(dogadjaj);
        }

        // GET: Radnik/Dogadjaj/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dogadjaj dogadjaj = await db.Dogadjaji.FindAsync(id);
            if (dogadjaj == null)
            {
                return HttpNotFound();
            }
            return View(dogadjaj);
        }

        // POST: Radnik/Dogadjaj/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "dogadjajId,naziv,datum,cenaKarte")] Dogadjaj dogadjaj)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dogadjaj).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(dogadjaj);
        }

        // GET: Radnik/Dogadjaj/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dogadjaj dogadjaj = await db.Dogadjaji.FindAsync(id);
            if (dogadjaj == null)
            {
                return HttpNotFound();
            }
            return View(dogadjaj);
        }

        // POST: Radnik/Dogadjaj/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Dogadjaj dogadjaj = await db.Dogadjaji.FindAsync(id);
            db.Dogadjaji.Remove(dogadjaj);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
