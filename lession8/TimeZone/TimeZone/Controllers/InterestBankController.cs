using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeZone.Models;

namespace TimeZone.Controllers
{
    public class InterestBankController : Controller
    {
        [HttpGet]
        public IActionResult Interest()
        {
            return View(new Bank());
        }
        [HttpPost]
        public IActionResult Interest(Bank model)
        {
            model.InterestAmount =  model.InventmentAmount * (model.YearlyInterestRate/100)/12 * model.NumberOfYear;
            return View("~/Views/InterestBank/hello.cshtml",model);
        }
    }
}
