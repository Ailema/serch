using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using WebApplication3.Context;
using WebApplication3.Models;
using System.Net;

namespace WebApplication3.Controllers
{
    public class EmpleadosController : Controller
    {
        private DataStore3 db = new DataStore3();
        public ActionResult Index()
        {
            return View(db.Empleados.ToList());
        }

        // GET: Empleados/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            else
            {
                Empleado X = db.Empleados.Find(id);
                if (X == null)
                {
                    return HttpNotFound();
                }
                else
                {
                    return View(X);
                }
            }
        }

        // GET: Empleados/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Empleados/Create
        [HttpPost]
        public ActionResult Create(Empleado Empleados)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Empleados.Add(Empleados);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(Empleados);
            }
            catch
            {
                return View(Empleados);
            }
        }

        // GET: Empleados/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            else
            {
                Empleado X = db.Empleados.Find(id);
                if (X == null)
                {
                    return HttpNotFound();
                }
                else
                {
                    return View(X);
                }
            }
        }

        // POST: Empleados/Edit/5
        [HttpPost]
        public ActionResult Edit(Empleado X)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Entry(X).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(X);
            }
            catch
            {
                return View(X);
            }
        }

        // GET: Empleados/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            else
            {
                Empleado X = db.Empleados.Find(id);
                if (X == null)
                {
                    return HttpNotFound();
                }
                else
                {
                    return View(X);
                }
            }
        }

        // POST: Empleados/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Empleado X)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    X = db.Empleados.Find(id);
                    if (X == null)
                    {
                        return HttpNotFound();
                    }
                    else
                    {
                        db.Empleados.Remove(X);
                        db.SaveChanges();
                    }

                    return RedirectToAction("Index");
                }
                return View(X);
            }
            catch
            {
                return View(X);
            }
        }
    }
}
