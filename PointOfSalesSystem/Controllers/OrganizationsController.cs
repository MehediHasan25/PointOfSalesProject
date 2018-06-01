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
    public class OrganizationsController : Controller
    {
        OrganizationsManager _organizationsManager = new OrganizationsManager();
        // GET: Organizations
        public ActionResult Index()
        {
            return View();
        }

        // GET: Organizations/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
        
        // GET: Organizations/Create
        public ActionResult Create()
        {
            var model = new OrganizationsCreateVM();
            model.Organizationses = _organizationsManager.GetAll();
            return View(model);
        }

        // POST: Organizations/Create
        [HttpPost]
        public ActionResult Create(OrganizationsCreateVM model)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    var organ = Mapper.Map<Organizations>(model);
                    bool isSaved = _organizationsManager.Save(organ);
                    if (isSaved)
                        return RedirectToAction("Create");
                }

                return RedirectToAction("Create");
            }
            catch(Exception exception)
            {
                ModelState.AddModelError("", exception.Message);
                model.Organizationses = _organizationsManager.GetAll();
                return View(model);
            }
            
        }

        // GET: Organizations/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Organizations/Edit/5
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

        // GET: Organizations/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Organizations/Delete/5
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
