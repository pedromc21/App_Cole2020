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
    public class DebtsController : Controller
    {
        private LocalDataContext db = new LocalDataContext();

        // GET: Debts
        public async Task<ActionResult> Index()
        {
            return View(await db.Debts.ToListAsync());
        }

        // GET: Debts/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Debt debt = await db.Debts.FindAsync(id);
            if (debt == null)
            {
                return HttpNotFound();
            }
            return View(debt);
        }

        // GET: Debts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Debts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "LLaveRef,Persona_Id,IdCiclo,Plantel,Concepto,Total,Recargo,Abono,Saldo,FechaVencimiento")] Debt debt)
        {
            if (ModelState.IsValid)
            {
                db.Debts.Add(debt);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(debt);
        }

        // GET: Debts/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Debt debt = await db.Debts.FindAsync(id);
            if (debt == null)
            {
                return HttpNotFound();
            }
            return View(debt);
        }

        // POST: Debts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "LLaveRef,Persona_Id,IdCiclo,Plantel,Concepto,Total,Recargo,Abono,Saldo,FechaVencimiento")] Debt debt)
        {
            if (ModelState.IsValid)
            {
                db.Entry(debt).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(debt);
        }

        // GET: Debts/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Debt debt = await db.Debts.FindAsync(id);
            if (debt == null)
            {
                return HttpNotFound();
            }
            return View(debt);
        }

        // POST: Debts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Debt debt = await db.Debts.FindAsync(id);
            db.Debts.Remove(debt);
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
