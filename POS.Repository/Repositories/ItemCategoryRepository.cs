using POS.Models.EntityModel;
using POS.Repository.Base;
using POS.Repository.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Repository.Repositories
{
    public class ItemCategoryRepository : Repository<ItemCategory>
    {
        public ItemCategoryRepository() : base(new PosManagementDbContext())
        {
        }
    }
}
