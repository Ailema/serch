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
    public class ProductsController : Controller
    {
        private DataStore db = new DataStore();
        // GET: Products
        public ActionResult Index()
        {
            return View(db.Products.ToList());
        }

        // GET: Products/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            else
            {
                Product X = db.Products.Find(id);
                if (X == null)
                {
                    return HttpNotFound();
                }else
                {
                    return View(X);
                }
            }
        }

        // GET: Products/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Products/Create
        [HttpPost]
        public ActionResult Create(Product Products)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Products.Add(Products);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(Products);
            }
            catch
            {
                return View(Products);
            }
        }

        // GET: Products/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            else
            {
                Product X = db.Products.Find(id);
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

        // POST: Products/Edit/5
        [HttpPost]
        public ActionResult Edit(Product X)
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

        // GET: Products/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            else
            {
                Product X = db.Products.Find(id);
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

        // POST: Products/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Product X)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    X = db.Products.Find(id);
                    if (X == null)
                    {
                        return HttpNotFound();
                    }
                    else
                    {
                        db.Products.Remove(X);
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
