using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Models.EntityModel
{
    public class Sales
    {
        
        public int Id { get; set; }
        public int SalesNumber { get; set; }
        public string SalesDate { get; set; }
        public int VAT { get; set; }
        public int Dicount { get; set; }
        public long SalesTotalAmount { get; set; }

        

       // public int Quantity { get; set; }



        //item Reference
        public int? ItemId { get; set; }
        public Item Item { get; set; }

        //Customer Refered
        public int? PartyId { get; set; }
        public Party Party { get; set; }

        //Branch Refered
        public int? BranchId { get; set; }
        public Branch Branch { get; set; }

        //Employee Refered
        public int? EmployeeInfoId { get; set; }
        public EmployeeInfo Employee { get; set; }

        //List of Sales Details
        public List<SalesDetails> SalesDetailses { get; set; }



    }
}
