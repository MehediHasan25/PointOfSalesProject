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
    public class BranchesController : Controller
    {
        BranchManager _branchManager = new BranchManager();
        OrganizationsManager _organizationsManager = new OrganizationsManager();
        // GET: Branches
        public ActionResult Index()
        {
            return View();
        }
    
        // GET: Branches/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Branches/Create
        public ActionResult Create()
        {
            var model = new BranchesCreateVM();
            var organizations = _organizationsManager.GetAll();
            model.Organizationses = organizations;
            model.Branches = _branchManager.GetAll();
            return View(model);
        }

        // POST: Branches/Create
        [HttpPost]
        public ActionResult Create(BranchesCreateVM model)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    var branch = Mapper.Map<Branch>(model);
                    bool isSaved = _branchManager.Save(branch);
                    if (isSaved)
                        return RedirectToAction("Create");
                }

            }
            catch (Exception exception)
            {
                ModelState.AddModelError("", exception.Message);

                
                var list = _organizationsManager.GetAll();
                model.Organizationses = list;
                model.Branches = _branchManager.GetAll();
                return View(model);
            }
            
            var organizations = _organizationsManager.GetAll();
            model.Organizationses = organizations;
            model.Branches = _branchManager.GetAll();
            return View(model);
        }

        // GET: Branches/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Branches/Edit/5
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

        // GET: Branches/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Branches/Delete/5
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
