using POS.Models.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PointOfSalesSystem.Models.ViewModels
{
    public class SalesCreateVM
    {
        public int Id { get; set; }
        public int SalesNumber { get; set; }
        public string SalesDate { get; set; }
        public int VAT { get; set; }
        public int Dicount { get; set; }
        public long SalesTotalAmount { get; set; }


        //item referenece
        public int? ItemId { get; set; }
        public List<Item> Items { get; set; }

        //Customer Refered
        public int? PartyId { get; set; }

        //Branch Refered
        public int? BranchId { get; set; }
        public List<Branch> Branch { get; set; }

        //Employee Refered
        public int? EmployeeInfoId { get; set; }
        public List<EmployeeInfo> Employee { get; set; }

        //List of Sales Details
        public List<SalesDetails> SalesDetailses { get; set; }


    }
}