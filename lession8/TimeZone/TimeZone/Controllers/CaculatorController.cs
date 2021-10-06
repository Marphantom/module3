using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeZone.Models;

namespace TimeZone.Controllers
{
    public class CaculatorController : Controller
    {

        [HttpGet]
        public IActionResult CaculatorResult()
        {
            return View(new Caculators());
        }

        [HttpPost]
        public IActionResult CaculatorResult(Caculators model, string word)
        {
            if(word == "add")
            {
                model.NumberResult = model.NumberA + model.NumberB;
            }
            if(word == "sub")
            {
                model.NumberResult = model.NumberA - model.NumberB;
            }
            if(word == "mul")
            {
                model.NumberResult = model.NumberA * model.NumberB;
            }
            if(word == "div")
            {
                model.NumberResult = model.NumberA / model.NumberB;
            }
            return View(model);
        }
    }
}
