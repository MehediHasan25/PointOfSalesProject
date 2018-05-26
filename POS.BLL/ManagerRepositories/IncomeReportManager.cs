using POS.BLL.BaseManager;
using POS.Models.EntityModel;
using POS.Repository.Base;
using POS.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.BLL.ManagerRepositories
{
    public class IncomeReportManager : Manager<IncomeReport>
    {
        public IncomeReportManager() : base(new IncomeReportRepository())
        {
        }
    }
}
