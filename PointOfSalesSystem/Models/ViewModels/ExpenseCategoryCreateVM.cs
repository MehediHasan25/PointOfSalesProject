using POS.Models.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PointOfSalesSystem.Models.ViewModels
{
    public class ExpenseCategoryCreateVM
    {
        public string Name { get; set; }
        public string ItemCategoryCode { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }
        public string RadioButton { get; set; }

        public int? ParentId { get; set; }
        public List<ExpenseCategory> Childs { get; set; }
    }
}