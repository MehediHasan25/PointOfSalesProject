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
    public class PurchaseReportDetailsManager : Manager<PurchaseReportDetails>
    {
        public PurchaseReportDetailsManager() : base(new PurchaseReportDetailsRepository())
        {

        }
    }
}
