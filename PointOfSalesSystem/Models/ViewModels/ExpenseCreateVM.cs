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
        
        [Display(Name = "Date")]
        public string ExpenseDate { get; set; }
        public double ExpenseAmount { get; set; }
        [Display(Name = "Description")]
        public string ReasonsOfExpense { get; set; }
        public long ExpenseTotalAmount { get; set; }

        //ExpenseItem Refered
        public int? ExpenseItemId { get; set; }
        public List<ExpenseItem> ExpenseItems { get; set; }

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