using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeZone.Models;
using TimeZone.Services;

namespace TimeZone.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeServices employeeSer;
        public EmployeeController(IEmployeeServices employeeServices)
        {
            this.employeeSer = employeeServices;
        }
        public IActionResult Show()
        {
            return View(employeeSer.Gets());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                employeeSer.Create(employee);
                return RedirectToAction("Show");
            }
            return View();
        }

    }
}
