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

namespace ZooVrt.Areas.Korisnik.Controllers
{
    public class RezervacijaController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Korisnik/Rezervacija
        public async Task<ActionResult> Index()
        {
            return View(await db.Rezervacije.ToListAsync());
        }

        // GET: Korisnik/Rezervacija/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rezervacija rezervacija = await db.Rezervacije.FindAsync(id);
            if (rezervacija == null)
            {
                return HttpNotFound();
            }
            return View(rezervacija);
        }

        // GET: Korisnik/Rezervacija/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Korisnik/Rezervacija/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "rezervacijaID,korisnickoIme,dogadjaj,termin,brRezervisanihKarata")] Rezervacija rezervacija)
        {
            if (ModelState.IsValid)
            {
                db.Rezervacije.Add(rezervacija);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(rezervacija);
        }

        // GET: Korisnik/Rezervacija/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rezervacija rezervacija = await db.Rezervacije.FindAsync(id);
            if (rezervacija == null)
            {
                return HttpNotFound();
            }
            return View(rezervacija);
        }

        // POST: Korisnik/Rezervacija/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "rezervacijaID,korisnickoIme,dogadjaj,termin,brRezervisanihKarata")] Rezervacija rezervacija)
        {
            if (ModelState.IsValid)
            {
                db.Entry(rezervacija).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(rezervacija);
        }

        // GET: Korisnik/Rezervacija/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rezervacija rezervacija = await db.Rezervacije.FindAsync(id);
            if (rezervacija == null)
            {
                return HttpNotFound();
            }
            return View(rezervacija);
        }

        // POST: Korisnik/Rezervacija/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Rezervacija rezervacija = await db.Rezervacije.FindAsync(id);
            db.Rezervacije.Remove(rezervacija);
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
