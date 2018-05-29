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
        public int Quantity { get; set; }
        [Display(Name = "Price")]
        public int PurchasePrice { get; set; }
        [Display(Name = "Purchase No")]
        public int PurchaseNumber { get; set; }
        [Display(Name = "Purchase Date")]
        public string PurchaseDate { get; set; }
        
        public string Remarks { get; set; }
        [Display(Name = "Purchase Total Amount")]
        public long PurchaseTotalAmount { get; set; }

        [Display(Name="Item Name")]
        public int? ItemId { get; set; }
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

    }
}