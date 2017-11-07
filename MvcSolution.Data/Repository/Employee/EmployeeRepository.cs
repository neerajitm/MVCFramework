using MvcSolution.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcSolution.Data
{
    public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(DbContext context) : base(context)
        {

        }
        public IEnumerable<Employee> GetEmployee()
        {
            return ((TestEntities)Dbcontext).Employees;
        }
    }
}
