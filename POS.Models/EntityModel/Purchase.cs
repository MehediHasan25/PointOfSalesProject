using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Models.EntityModel
{
    public class Purchase
    {
        public int Id { get; set; }
        public int PurchaseNumber { get; set; }
        public string PurchaseDate { get; set; }
        public string Remarks { get; set; }
        public long PurchaseTotalAmount { get; set; }

        //Organization Refered
        public int OrgnaizationId { get; set; }
        public Organizations organization { get; set; }


        //Supplier Refered
        public int PartyId { get; set; }
        public Party Party { get; set; }

        //Branch Refered
        public int BranchId { get; set; }  
        public Branch Branch { get; set; }

        //Employee Refered
        public int EmployeeInfoId { get; set; }
        public EmployeeInfo Employee { get; set; }
        
        /// List OF Purchase Detais
        public List<PurchaseDetails> PurchaseDetailses { get; set; }

        

    }
}
