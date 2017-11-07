using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvcSolution.Models;

namespace MvcSolution.Services
{

    public interface IEmployeeService
    {
        IEnumerable<Employee> GetEmployee();
    }
}
