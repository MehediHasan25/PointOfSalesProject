using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Models.EntityModel
{
    public class Item
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public double CostsPrice { get; set; }
        public double SalesPrice { get; set; }
        public string ItemCode { get; set; }
        public byte[] Image { get; set; }
        public string Description { get; set; }
        public int? ItemCategoryId { get; set; }
        public ItemCategory ItemCategory { get; set; }

    }
}
