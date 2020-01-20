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
    public class GroupsController : Controller
    {
        private LocalDataContext db = new LocalDataContext();

        // GET: Groups
        public async Task<ActionResult> Index()
        {
            var groups = db.Groups.Include(g => g.Student);
            return View(await groups.ToListAsync());
        }

        // GET: Groups/Details/5
        public async Task<ActionResult> Details(int Grupo_Id, int Persona_Id)
        {
            if (Grupo_Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Group group = await db.Groups.FindAsync(Grupo_Id, Persona_Id);
            if (group == null)
            {
                return HttpNotFound();
            }
            return View(group);
        }

        // GET: Groups/Create
        public ActionResult Create()
        {
            ViewBag.Persona_Id = new SelectList(db.Students, "Persona_Id", "Matricula");
            return View();
        }

        // POST: Groups/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Grupo_Id,Persona_Id,Clave,NameGrupo,TipoGrupo")] Group group)
        {
            if (ModelState.IsValid)
            {
                db.Groups.Add(group);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.Persona_Id = new SelectList(db.Students, "Persona_Id", "Matricula", group.Persona_Id);
            return View(group);
        }

        // GET: Groups/Edit/5
        public async Task<ActionResult> Edit(int Grupo_Id, int Persona_Id)
        {
            if (Grupo_Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Group group = await db.Groups.FindAsync(Grupo_Id, Persona_Id);
            if (group == null)
            {
                return HttpNotFound();
            }
            ViewBag.Persona_Id = new SelectList(db.Students, "Persona_Id", "Matricula", group.Persona_Id);
            return View(group);
        }

        // POST: Groups/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Grupo_Id,Persona_Id,Clave,NameGrupo,TipoGrupo")] Group group)
        {
            if (ModelState.IsValid)
            {
                db.Entry(group).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.Persona_Id = new SelectList(db.Students, "Persona_Id", "Matricula", group.Persona_Id);
            return View(group);
        }

        // GET: Groups/Delete/5
        public async Task<ActionResult> Delete(int Grupo_Id, int Persona_Id)
        {
            if (Grupo_Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Group group = await db.Groups.FindAsync(Grupo_Id, Persona_Id);
            if (group == null)
            {
                return HttpNotFound();
            }
            return View(group);
        }

        // POST: Groups/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Group group = await db.Groups.FindAsync(id);
            db.Groups.Remove(group);
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
