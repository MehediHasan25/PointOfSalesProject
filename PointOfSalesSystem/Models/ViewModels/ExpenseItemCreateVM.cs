using POS.Models.EntityModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PointOfSalesSystem.Models.ViewModels
{
    public class ExpenseItemCreateVM
    {
        
        public string Name { get; set; }
        public double Price { get; set; }
        [Display(Name= "Item Code")]
        public string ItemCode { get; set; }
        public byte[] Image { get; set; }
        public string Description { get; set; }

        //Expense Category Refere
        [Display(Name = "Category")]
        public int? ExpenseCategoryId { get; set; }
        public List <ExpenseCategory> ExpenseCategories { get; set; }
        public List<ExpenseItem> ChildItems { get; set; }

    }
}