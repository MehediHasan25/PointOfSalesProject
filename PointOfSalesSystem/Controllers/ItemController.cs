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
    public class ItemController : Controller
    {
        ItemManager _itemManager = new ItemManager();
        ItemCategoryManager _itemCategoryManager = new ItemCategoryManager();

        // GET: Item
        public ActionResult Index()
        {
            return View();
        }

        // GET: Item/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Item/Create
        public ActionResult Create()
        {
            var model = new ItemCreateVM();
            model.ItemCategories = _itemCategoryManager.GetAll();
            model.ChildItems = _itemManager.GetAll();
            return View(model);
        }

        // POST: Item/Create
        [HttpPost]
        public ActionResult Create(ItemCreateVM model)
        {
            try
            {
                var item = Mapper.Map<Item>(model);
                bool isSaved = _itemManager.Save(item);
                if (isSaved)
                    return RedirectToAction("Create");
            }
            catch (Exception exception)
            {
                ModelState.AddModelError("", exception.Message);

                model.ItemCategories = _itemCategoryManager.GetAll();
                model.ChildItems = _itemManager.GetAll();
                return View(model);
            }
            model.ItemCategories = _itemCategoryManager.GetAll();
            model.ChildItems = _itemManager.GetAll();
            return View(model);
        }

        // GET: Item/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Item/Edit/5
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

        // GET: Item/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Item/Delete/5
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
