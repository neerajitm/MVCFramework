using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvcSolution.Data;
using MvcSolution.Models;
using AutoMapper;
using System.Collections;

namespace MvcSolution.Services
{
    public class EmployeeService : IEmployeeService
    {
        public IEmployeeRepository _employeeRepository = null;
        public IMapper _mapper = null;

        public EmployeeService(IEmployeeRepository employeeRepository, IMapper mapper)
        {
            _employeeRepository = employeeRepository;
            _mapper = mapper;
        }
        public IEnumerable<Employee> GetEmployee()
        {
            return _mapper.Map<IEnumerable<Entity.Employee>, IEnumerable<Employee>>(_employeeRepository.GetEmployee());
        }
    }
}
