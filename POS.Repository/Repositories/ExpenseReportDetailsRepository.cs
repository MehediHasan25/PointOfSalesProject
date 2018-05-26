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
    public class ExpenseReportDetailsRepository : Repository<ExpenseReportDetails>
    {
        public ExpenseReportDetailsRepository( ) : base(new PosManagementDbContext())
        {
        }
    }
}
