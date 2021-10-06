using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeZone.Models;

namespace TimeZone.Controllers
{
    public class ChangeUSDController : Controller
    {
        [HttpGet]
        public IActionResult Change()
        {
            return View(new USDToVN());
        }

        [HttpPost]
        public IActionResult Change(USDToVN model)
        {
            if(ModelState.IsValid)
            {
                model.VND = model.rate * model.USD;
            }
            return View(model);
        }
    }
}
