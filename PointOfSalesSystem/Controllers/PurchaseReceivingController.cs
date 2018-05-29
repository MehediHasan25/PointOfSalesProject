using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PointOfSalesSystem.Controllers
{
    public class PurchaseReceivingController : Controller
    {
        // GET: PurchaseReceiving
        public ActionResult Index()
        {
            return View();
        }

        // GET: PurchaseReceiving/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PurchaseReceiving/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PurchaseReceiving/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: PurchaseReceiving/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PurchaseReceiving/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: PurchaseReceiving/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PurchaseReceiving/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
