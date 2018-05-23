using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Models.EntityModel
{
   public class PurchaseDetails
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int PurchaseItemTotalPrice { get; set; }

        public int PurchaseId { get; set; }
        public Purchase Purchase  { get; set; }

        public int ItemId{ get; set; }
        public Item Item { get; set; }

    }
}
