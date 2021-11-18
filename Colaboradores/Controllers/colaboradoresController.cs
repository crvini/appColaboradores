using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Colaboradores;

namespace Colaboradores.Controllers
{
    public class colaboradoresController : Controller
    {
        private PruebaCEntities db = new PruebaCEntities();

        // GET: colaboradores
        public ActionResult Index()
        {
            return View(db.colaboradores.ToList());
        }

        // GET: colaboradores/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            colaboradores colaboradores = db.colaboradores.Find(id);
            if (colaboradores == null)
            {
                return HttpNotFound();
            }
            return View(colaboradores);
        }

        // GET: colaboradores/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: colaboradores/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,Nombre,Apellido,FechaNacimiento,EstadoCivil,GradoA,Direccion")] colaboradores colaboradores)
        {
            if (ModelState.IsValid)
            {
                db.colaboradores.Add(colaboradores);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(colaboradores);
        }

        // GET: colaboradores/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            colaboradores colaboradores = db.colaboradores.Find(id);
            if (colaboradores == null)
            {
                return HttpNotFound();
            }
            return View(colaboradores);
        }

        // POST: colaboradores/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,Nombre,Apellido,FechaNacimiento,EstadoCivil,GradoA,Direccion")] colaboradores colaboradores)
        {
            if (ModelState.IsValid)
            {
                db.Entry(colaboradores).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(colaboradores);
        }

        // GET: colaboradores/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            colaboradores colaboradores = db.colaboradores.Find(id);
            if (colaboradores == null)
            {
                return HttpNotFound();
            }
            return View(colaboradores);
        }

        // POST: colaboradores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            colaboradores colaboradores = db.colaboradores.Find(id);
            db.colaboradores.Remove(colaboradores);
            db.SaveChanges();
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
