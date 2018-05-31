using POS.Models.EntityModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PointOfSalesSystem.Models.ViewModels
{
    public class PurchaseReceivingCreateVM
    {
        public int Id { get; set; }
       
        
        [Display(Name = "Purchase No")]
        public int PurchaseNumber { get; set; }
        [Display(Name = "Purchase Date")]
        public string PurchaseDate { get; set; }
        
        public string Remarks { get; set; }
        [Display(Name = "Purchase Total Amount")]
        public long PurchaseTotalAmount { get; set; }

        
        public List<Item> Items { get; set; }

        [Display(Name = "Branch")]
        //Branch Refered
        public int? BranchId { get; set; }
        public List<Branch> Branches { get; set; }

        [Display(Name = "Supplier")]
        //Supplier Refered
        public int? PartyId { get; set; }
        public List<Party> Parties { get; set; }


        [Display(Name = "Employee")]
        //Employee Refered
        public int? EmployeeInfoId { get; set; }
        public List<EmployeeInfo> EmployeeInfoes { get; set; }

        public List<PurchaseReceivingDetails> PurchaseReceivingDetailses { get; set; }

    }
}