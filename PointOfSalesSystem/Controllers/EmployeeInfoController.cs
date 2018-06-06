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
    public class EmployeeInfoController : Controller
    {
        BranchManager _branchManager = new BranchManager();
        EmployeeInfoManager _employeeInfoManager = new EmployeeInfoManager();
        // GET: EmployeeInfo
        public ActionResult Index()
        {
            return View();
        }

        // GET: EmployeeInfo/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EmployeeInfo/Create
        public ActionResult Create()
        {
            var model = new EmployeeInfoCreateVM();
            model.Branches = _branchManager.GetAll();
            model.EmployeeInfoses = _employeeInfoManager.GetAll();
            return View(model);
        }

        // POST: EmployeeInfo/Create
        [HttpPost]
        public ActionResult Create(EmployeeInfoCreateVM model)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    var EmployeeInfo = Mapper.Map<EmployeeInfo>(model);
                    bool IsSaved = _employeeInfoManager.Save(EmployeeInfo);
                    if(IsSaved)
                    {
                        RedirectToAction("Create");
                    }
                }
                
                return RedirectToAction("Create");
            }
            catch(Exception exception)
            {
                ModelState.AddModelError("", exception.Message);
                model.Branches = _branchManager.GetAll();
                model.EmployeeInfoses = _employeeInfoManager.GetAll();
                return View(model);
            }
        }

        // GET: EmployeeInfo/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EmployeeInfo/Edit/5
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

        // GET: EmployeeInfo/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EmployeeInfo/Delete/5
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


        public JsonResult GetByBranch(int? branchId)
        {
            if (branchId == null)
            {
                return null;

            }

            var employeeInfoList= _employeeInfoManager.Get(c => c.BranchId == branchId);

            if (employeeInfoList == null)
            {
                return null;
            }
            var jsonData = employeeInfoList.Select(c => new {c.Id,c.Name,c.Code } );

            return Json(jsonData, JsonRequestBehavior.AllowGet);


        }


    }
}
