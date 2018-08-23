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
    [Authorize(Roles = "Radnik")]
    public class TerminController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Radnik/Termin
        public async Task<ActionResult> Index()
        {
            return View(await db.Termini.ToListAsync());
        }

        // GET: Radnik/Termin/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Termin termin = await db.Termini.FindAsync(id);
            if (termin == null)
            {
                return HttpNotFound();
            }
            return View(termin);
        }

        // GET: Radnik/Termin/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Radnik/Termin/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "terminID,vremePocetka,vremeKraja,brKarata")] Termin termin)
        {
            if (ModelState.IsValid)
            {
                db.Termini.Add(termin);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(termin);
        }

        // GET: Radnik/Termin/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Termin termin = await db.Termini.FindAsync(id);
            if (termin == null)
            {
                return HttpNotFound();
            }
            return View(termin);
        }

        // POST: Radnik/Termin/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "terminID,vremePocetka,vremeKraja,brKarata")] Termin termin)
        {
            if (ModelState.IsValid)
            {
                db.Entry(termin).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(termin);
        }

        // GET: Radnik/Termin/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Termin termin = await db.Termini.FindAsync(id);
            if (termin == null)
            {
                return HttpNotFound();
            }
            return View(termin);
        }

        // POST: Radnik/Termin/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Termin termin = await db.Termini.FindAsync(id);
            db.Termini.Remove(termin);
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
