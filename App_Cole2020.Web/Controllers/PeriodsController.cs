using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using App_Cole2020.Common.Models;
using App_Cole2020.Web.Models;

namespace App_Cole2020.Web.Controllers
{
    public class PeriodsController : Controller
    {
        private LocalDataContext db = new LocalDataContext();

        // GET: Periods
        public async Task<ActionResult> Index()
        {
            return View(await db.Periods.ToListAsync());
        }

        // GET: Periods/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Period period = await db.Periods.FindAsync(id);
            if (period == null)
            {
                return HttpNotFound();
            }
            return View(period);
        }

        // GET: Periods/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Periods/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Periodo_Id,Ciclo_Escolar")] Period period)
        {
            if (ModelState.IsValid)
            {
                db.Periods.Add(period);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(period);
        }

        // GET: Periods/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Period period = await db.Periods.FindAsync(id);
            if (period == null)
            {
                return HttpNotFound();
            }
            return View(period);
        }

        // POST: Periods/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Periodo_Id,Ciclo_Escolar")] Period period)
        {
            if (ModelState.IsValid)
            {
                db.Entry(period).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(period);
        }

        // GET: Periods/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Period period = await db.Periods.FindAsync(id);
            if (period == null)
            {
                return HttpNotFound();
            }
            return View(period);
        }

        // POST: Periods/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Period period = await db.Periods.FindAsync(id);
            db.Periods.Remove(period);
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
