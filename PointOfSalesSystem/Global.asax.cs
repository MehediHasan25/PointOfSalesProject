using AutoMapper;
using PointOfSalesSystem.Models.ViewModels;
using POS.Models.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace PointOfSalesSystem
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<ItemCategoryCreateVM, ItemCategory>();
                cfg.CreateMap<ItemCategory, ItemCategoryCreateVM>();

                cfg.CreateMap<OrganizationsCreateVM, Organizations>();
                cfg.CreateMap<Organizations, OrganizationsCreateVM>();

                cfg.CreateMap<BranchesCreateVM, Branch>();
                cfg.CreateMap<Branch, BranchesCreateVM>();

                cfg.CreateMap<ItemCreateVM, Item>();
                cfg.CreateMap<Item, ItemCreateVM>();

                cfg.CreateMap<ExpenseCategoryCreateVM, ExpenseCategory>();
                cfg.CreateMap<ExpenseCategory, ExpenseCategoryCreateVM>();

                cfg.CreateMap<ExpenseItemCreateVM, ExpenseItem>();
                cfg.CreateMap<ExpenseItem, ExpenseItemCreateVM>();

                cfg.CreateMap<PartyCreateVM, Party>();
                cfg.CreateMap<Party, PartyCreateVM>();

            }
             );
        }
    }
}
