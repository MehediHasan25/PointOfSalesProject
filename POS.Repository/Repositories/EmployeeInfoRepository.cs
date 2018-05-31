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
    public class EmployeeInfoRepository : Repository<EmployeeInfo>
    {
        public EmployeeInfoRepository() : base(new PosManagementDbContext())
        {
        }

        public PosManagementDbContext Context
        {
            get {
                return (PosManagementDbContext)Db;
                 }
                
         }


    }
}
