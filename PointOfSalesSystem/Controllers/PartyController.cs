using AutoMapper;
using PointOfSalesSystem.Models.ViewModels;
using POS.BLL.ManagerRepositories;
using POS.Models.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PointOfSalesSystem.Controllers
{
    public class PartyController : Controller
    {
        PartyManager _partyManager = new PartyManager(); 
        
            // GET: Party
        public ActionResult Index()
        {
            return View();
        }

        // GET: Party/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Party/Create
        public ActionResult Create()
        {
            var model = new PartyCreateVM();
            model.Parties = _partyManager.GetAll();

            return View(model);
        }

        // POST: Party/Create
        [HttpPost]
        public ActionResult Create(PartyCreateVM model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var party = Mapper.Map<Party>(model);
                    bool isSaved = _partyManager.Save(party);
                    if (isSaved)
                        return RedirectToAction("Create");
                }

                return RedirectToAction("Create");
            }
            catch(Exception exception)
            {
                ModelState.AddModelError("", exception.Message);
                model.Parties = _partyManager.GetAll();
                return View(model);
            }

        }

        // GET: Party/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Party/Edit/5
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

        // GET: Party/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Party/Delete/5
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
