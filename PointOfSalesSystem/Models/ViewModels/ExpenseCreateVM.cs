using POS.Models.EntityModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PointOfSalesSystem.Models.ViewModels
{
    public class ExpenseCreateVM
    {
        public int Id { get; set; }

        [Display(Name = "Qty")]
        public int ExpenseQuantity { get; set; }
        
        
        
        public double Amount { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }
        public long ExpenseTotalAmount { get; set; }

        //ExpenseItem Refered
        
        public List<ExpenseItem> ExpenseItems { get; set; }

        public string ExpenseDate { get; set; }


        //Branch Refered
        public int? BranchId { get; set; }
        public List<Branch> Branches { get; set; }

        //Employee Refered
        public int? EmployeeInfoId { get; set; }
        public List<EmployeeInfo> EmployeeInfoes { get; set; }

        /// List OF Purchase Detais
        public List<ExpenseDetails> ExpenseDetailses { get; set; }
    }
}