using DemoMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoMVC.Controllers
{
    public class HomeController : Controller
    {
        private IEmployeeRepository employeeRepository;

        public HomeController()
        {
            employeeRepository = new EmployeeRepository();
        }

        public ViewResult Index()
        {
            //ViewData["employees"] = employeeRepository.Gets();
            //ViewBag.Employees = employeeRepository.Gets();
            return View(employeeRepository.Gets());
        }
    }
}
