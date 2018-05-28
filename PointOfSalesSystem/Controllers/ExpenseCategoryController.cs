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
    public class ExpenseCategoryController : Controller
    {
        ExpenseCategoryManager _expenseCategoryManager = new ExpenseCategoryManager();


        // GET: ExpenseCategory
        public ActionResult Index()
        {
            return View();
        }

        // GET: ExpenseCategory/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ExpenseCategory/Create
        public ActionResult Create()
        {
            var model = new ExpenseCategoryCreateVM();
            model.Childs = _expenseCategoryManager.GetAll();
            return View(model);
        }

        // POST: ExpenseCategory/Create
        [HttpPost]
        public ActionResult Create(ExpenseCategoryCreateVM model)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    var expenseCategory = Mapper.Map<ExpenseCategory>(model);
                    bool isSaved = _expenseCategoryManager.Save(expenseCategory);
                    if (isSaved)
                        return RedirectToAction("Create");
                }
            }
            catch (Exception exception)
            {
                ModelState.AddModelError("", exception.Message);

                var expenseCategoryList = _expenseCategoryManager.GetAll();
                model.Childs = expenseCategoryList;
                return View(model);
            }
            var expneseCategoryList = _expenseCategoryManager.GetAll();
            model.Childs = expneseCategoryList;
            return View(model);
        }

        // GET: ExpenseCategory/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ExpenseCategory/Edit/5
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

        // GET: ExpenseCategory/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ExpenseCategory/Delete/5
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
