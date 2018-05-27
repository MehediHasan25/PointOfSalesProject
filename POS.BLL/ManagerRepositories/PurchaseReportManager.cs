using POS.BLL.BaseManager;
using POS.Models.EntityModel;
using POS.Repository.Repositories;
using POS.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.BLL.ManagerRepositories
{
    public class PurchaseReportManager : Manager<PurchaseReport>
    {
        public PurchaseReportManager() : base(new PurchaseReportRepository())
        {

        }
    }
}
