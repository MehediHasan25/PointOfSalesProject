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
    
    public class ExpensesController : Controller
    {
        ExpenseManager expenseManager = new ExpenseManager();
        ExpenseItemManager _expenseItemManager = new ExpenseItemManager();
        BranchManager _branchManager = new BranchManager();
        EmployeeInfoManager _employeeInfoManager = new EmployeeInfoManager();

        // GET: Expenses
        public ActionResult Index()
        {
            return View();
        }

        // GET: Expenses/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Expenses/Create
        public ActionResult Create()
        {
            var model = new ExpenseCreateVM();
            model.ExpenseItems = _expenseItemManager.GetAll();

            model.Branches = _branchManager.GetAll();

            model.EmployeeInfoes = _employeeInfoManager.GetAll();
             
            return View(model);
        }

        // POST: Expenses/Create
        [HttpPost]
        public ActionResult Create(ExpenseCreateVM model)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    var expense = Mapper.Map<Expense>(model);
                    bool isSaved = expenseManager.Save(expense);
                    if (isSaved)
                        return RedirectToAction("Create");
                }
            }
            catch (Exception exception)
            {
                ModelState.AddModelError("", exception.Message);

                model.ExpenseItems = _expenseItemManager.GetAll();

                model.Branches = _branchManager.GetAll();

                model.EmployeeInfoes = _employeeInfoManager.GetAll();

                return View(model);
            }
            model.ExpenseItems = _expenseItemManager.GetAll();

            model.Branches = _branchManager.GetAll();

            model.EmployeeInfoes = _employeeInfoManager.GetAll();

            return View(model);
        }
    }

        
        
    }

