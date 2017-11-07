using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MVCSolution.Controllers
{
    public class EmployeeController : Controller
    {
        //IEmployeeRepository _employeeRepository = null;
        //IManagerRepository _managerRepository = null;
        public EmployeeController()
        {
            //_employeeRepository = employeeRepository;
            //   _managerRepository = managerRepository;
        }

        public ActionResult Index()
        {
            //var result = _employeeRepository.GetAll().ToList();
            return View();
        }

        public ActionResult Create()
        {
            //Bindlist();
            return View();
        }

        //[HttpPost]
        //public ActionResult Create()
        //{
        //    try
        //    {
        //        //  _employeeRepository.Create(employee);
        //        // _employeeRepository.Commit();
        //        // Bindlist();
        //    }
        //    catch
        //    { }
        //    return View();
        //}

        public ActionResult Edit(int ID)
        {
            //Bindlist();
            // var employee = _employeeRepository.GetAll().Where(a => a.ID == ID).SingleOrDefault();
            return View();
        }

        //[HttpPost]
        //public ActionResult Edit(int ID, Employee employee)
        //{
        //    //var emp = _employeeRepository.GetAll().Where(a => a.ID == ID).SingleOrDefault();
        //    //if (TryUpdateModel<Employee>(emp))
        //    //{
        //    //    _employeeRepository.Commit();
        //    //}
        //    //Bindlist();
        //    return View();
        //}

        public void Bindlist()
        {
            //var lstManager = _managerRepository.GetAll().Select(a => new
            //{
            //    Name = a.Name,
            //    ManagerID = a.ID
            //}).ToList();

            //ViewBag.ListManager = new SelectList(lstManager, "ManagerID", "Name");
        }
    }
}