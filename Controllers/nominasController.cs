using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Final.Models;

namespace Final.Controllers
{
    public class nominasController : Controller
    {
        private EmpresaEntities1 db = new EmpresaEntities1();

        // GET: nominas
        public ActionResult Index()
        {
            var total = from tab in db.empleado
                        select tab;

            ViewBag.Suma = total.Sum(tab => tab.Salario);
            return View(db.nominas.ToList());
        }

        // GET: nominas/Details/5
        public ActionResult Details(int? id)
        {
            var total = from tab in db.empleado
                        select tab;

            ViewBag.Suma = total.Sum(tab => tab.Salario);


            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            nominas nominas = db.nominas.Find(id);
            if (nominas == null)
            {
                return HttpNotFound();
            }
            return View(nominas);
        }

        // GET: nominas/Create
        public ActionResult Create()
        {
            //consulta linq
            var total = from tab in db.empleado
                        select tab;

            ViewBag.Suma = total.Sum(tab => tab.Salario);
            return View();
        }

        // POST: nominas/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,Año,mes,total")] nominas nominas)
        {
            if (ModelState.IsValid)
            {
                db.nominas.Add(nominas);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(nominas);
        }

        // GET: nominas/Edit/5
        public ActionResult Edit(int? id)
        {

            var total = from tab in db.empleado
                        select tab;

            ViewBag.Suma = total.Sum(tab => tab.Salario);


            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            nominas nominas = db.nominas.Find(id);
            if (nominas == null)
            {
                return HttpNotFound();
            }
            return View(nominas);
        }

        // POST: nominas/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,Año,mes,total")] nominas nominas)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nominas).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nominas);
        }

        // GET: nominas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            nominas nominas = db.nominas.Find(id);
            if (nominas == null)
            {
                return HttpNotFound();
            }
            return View(nominas);
        }

        // POST: nominas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            nominas nominas = db.nominas.Find(id);
            db.nominas.Remove(nominas);
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
