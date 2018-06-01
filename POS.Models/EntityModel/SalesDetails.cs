using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Models.EntityModel
{
   public class SalesDetails
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int SalesItemTotalPrice { get; set; }
        public double SalesPrice { get; set; }

        public int? SalesId { get; set; }
        public Sales Sales { get; set; }

        public int? ItemId { get; set; }
        public Item Item { get; set; }
    }
}
