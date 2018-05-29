using POS.Models.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PointOfSalesSystem.Models.ViewModels
{
    public class PurchaseReceivingCreateVM
    {
        public int Id { get; set; }
        public int PurchaseNumber { get; set; }
        public string PurchaseDate { get; set; }
        public string Remarks { get; set; }
        public long PurchaseTotalAmount { get; set; }

        //Branch Refered
        public int? BranchId { get; set; }
        public List<Branch> Branches { get; set; }


        //Supplier Refered
        public int? PartyId { get; set; }
        public List <Party> Parties { get; set; }



        //Employee Refered
        public int? EmployeeInfoId { get; set; }
        public List<EmployeeInfo> EmployeeInfoes { get; set; }

        /// List OF Purchase Detais
        public List<PurchaseReceivingDetails> PurchaseReceivingDetailses { get; set; }
    }
}