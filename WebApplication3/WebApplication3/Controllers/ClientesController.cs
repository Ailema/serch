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
    public class ClientesController : Controller
    {
        private DataStore2 db = new DataStore2();

        public ActionResult Index()
        {
            return View(db.Clientes.ToList());
        }

        // GET: Clientes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            else
            {
                Cliente X = db.Clientes.Find(id);
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

        // GET: Clientes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Clientes/Create
        [HttpPost]
        public ActionResult Create(Cliente Clientes)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Clientes.Add(Clientes);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(Clientes);
            }
            catch
            {
                return View(Clientes);
            }
        }

        // GET: Clientes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            else
            {
                Cliente X = db.Clientes.Find(id);
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

        // POST: Clientes/Edit/5
        [HttpPost]
        public ActionResult Edit(Cliente X)
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

        // GET: Clientes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            else
            {
                Cliente X = db.Clientes.Find(id);
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

        // POST: Clientes/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Cliente X)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    X = db.Clientes.Find(id);
                    if (X == null)
                    {
                        return HttpNotFound();
                    }
                    else
                    {
                        db.Clientes.Remove(X);
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
