using MvcSolution.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcSolution.Data
{
    public class ManagerRepository : GenericRepository<Manager>, IManagerRepository
    {
        public ManagerRepository(DbContext context) : base(context)
        {

        }
    }
}
