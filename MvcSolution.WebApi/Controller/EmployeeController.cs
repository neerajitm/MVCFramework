using MvcSolution.Data;
using MvcSolution.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MvcSolution.WebApi
{
    public class EmployeeController : ApiController
    {
        public IEmployeeService _employeeService = null;
        //public IEmployeeRepository _employeeService = null;
        #region constructor
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        #endregion

        [HttpGet]
        public IHttpActionResult Get()
        {
            var employee = _employeeService.GetEmployee();


            if (employee != null)
                return Ok(employee);
            else
                return NotFound();
        }
    }
}
