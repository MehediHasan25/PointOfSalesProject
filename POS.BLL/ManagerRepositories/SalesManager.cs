using POS.BLL.BaseManager;
using POS.Models.EntityModel;
using POS.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.BLL.ManagerRepositories
{
    public class SalesManager : Manager<Sales>
    {
        public SalesManager() : base(new SalesRepository())
        {

        }
    }
}
