using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Models.EntityModel
{
   public class Stock
    {
        public int Id { get; set; }
        public int StockQuantity { get; set; }

        //Item Reference
        public int ItemId { get; set; }
        public Item Item { get; set; }
    }
}
