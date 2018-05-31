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
    public class ItemCategoryController : Controller
    {
        ItemCategoryManager _itemCategoryManager = new ItemCategoryManager();  
        // GET: ItemCategory
        public ActionResult Index()
        {
            var itemCategoryList = _itemCategoryManager.GetAll();

            return View(itemCategoryList);
        }

        // GET: ItemCategory/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ItemCategory/Create
        public ActionResult Create()
        {
            var model = new ItemCategoryCreateVM();
            model.Child = _itemCategoryManager.GetAll();
            return View(model);
        }

        // POST: ItemCategory/Create
        [HttpPost]
        public ActionResult Create(ItemCategoryCreateVM model)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    var item = Mapper.Map<ItemCategory>(model);
                    bool isSaved = _itemCategoryManager.Save(item);
                    if (isSaved)
                        return RedirectToAction("create");
                }

            }
            catch (Exception exception)
            {
                ModelState.AddModelError("", exception.Message);

                var itemCategoryList = _itemCategoryManager.GetAll();
                model.Child = itemCategoryList;
                return View(model);
            }
            var itemCategory = _itemCategoryManager.GetAll();
            model.Child = itemCategory;
            return View(model);
        }

        // GET: ItemCategory/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ItemCategory/Edit/5
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

        // GET: ItemCategory/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ItemCategory/Delete/5
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
