using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Models.EntityModel
{
   public class PurchaseReportDetails
    {
        public int Id { get; set; }
        public string  Date { get; set; }
        public string  Description { get; set; }
        public double PurchaseTotal { get; set; }

        

        public int? PartyId { get; set; }
        public Party Party { get; set; }

        public int? PurchaseReportId { get; set; }
        public PurchaseReport PurchaseReport { get; set; }
    }
}
