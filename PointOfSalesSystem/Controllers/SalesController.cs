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
    public class SalesController : Controller
    {

        ItemManager _itemManager = new ItemManager();
        BranchManager _branchManager = new BranchManager();
        EmployeeInfoManager _employeeInfoManager = new EmployeeInfoManager();
        SalesManager _salesManager = new SalesManager();

        // GET: Sales
        public ActionResult Index()
        {
            return View();
        }

        // GET: Sales/Details/5
        public ActionResult Details(int id)
        {

            return View();
        }

        // GET: Sales/Create
        public ActionResult Create()
        {
            var model = new SalesCreateVM();
            model.Items = _itemManager.GetAll();
            model.Branches = _branchManager.GetAll();
            model.EmployeeInfoes = _employeeInfoManager.GetAll();
            return View(model);
        }

        // POST: Sales/Create
        [HttpPost]
        public ActionResult Create(SalesCreateVM model)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    var SalesList = Mapper.Map<Sales>(model);
                    bool isSaved = _salesManager.Save(SalesList);
                    if(isSaved)
                    {
                        return RedirectToAction("Create");
                    }
                }
                
            }
            catch(Exception exception)
            {
                ModelState.AddModelError("", exception.Message);
                model.Items = _itemManager.GetAll();
                model.Branches = _branchManager.GetAll();
                model.EmployeeInfoes = _employeeInfoManager.GetAll();
                return View(model);
            }
            
            model.Items = _itemManager.GetAll();
            model.Branches = _branchManager.GetAll();
            model.EmployeeInfoes = _employeeInfoManager.GetAll();
            return View(model);
        }

        // GET: Sales/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Sales/Edit/5
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

        // GET: Sales/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Sales/Delete/5
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
