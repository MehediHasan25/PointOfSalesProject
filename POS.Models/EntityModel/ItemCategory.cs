using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Models.EntityModel
{
   public class ItemCategory
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public string  ItemCategoryCode { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }
        

        //Item Category ParentId REFER
        public int? ParentId { get; set; }
        public ItemCategory Parent { get; set; }

        //List of Childs
        public List<ItemCategory> Childs { get; set; }
    }
}
