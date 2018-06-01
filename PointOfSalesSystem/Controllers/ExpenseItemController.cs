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
    public class ExpenseItemController : Controller
    {
        ExpenseItemManager _expenseItemManager = new ExpenseItemManager();
        ExpenseCategoryManager _expenseCategoryManager = new ExpenseCategoryManager();
       
            // GET: ExpenseItem
        public ActionResult Index()
        {
            return View();
        }

        // GET: ExpenseItem/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ExpenseItem/Create
        public ActionResult Create()
        {
            var model = new ExpenseItemCreateVM();
            model.ExpenseCategories = _expenseCategoryManager.GetAll();
            model.ChildItems = _expenseItemManager.GetAll();
            return View(model);
        }

        // POST: ExpenseItem/Create
        [HttpPost]
        public ActionResult Create(ExpenseItemCreateVM model)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    var item = Mapper.Map<ExpenseItem>(model);
                    bool isSaved = _expenseItemManager.Save(item);
                    if (isSaved)
                        return RedirectToAction("Create");
                }

            }
            catch (Exception exception)
            {

                ModelState.AddModelError("", exception.Message);
                var expenseCategoryList = _expenseCategoryManager.GetAll();
                model.ExpenseCategories = expenseCategoryList;
                model.ChildItems = _expenseItemManager.GetAll();
                return View(model);
            }
            var expenseCategory = _expenseCategoryManager.GetAll();
            model.ExpenseCategories = expenseCategory;
            model.ChildItems = _expenseItemManager.GetAll();
            return View(model);
        }

        // GET: ExpenseItem/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ExpenseItem/Edit/5
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

        // GET: ExpenseItem/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ExpenseItem/Delete/5
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
