using BMI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BMI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(new BMIResult());
        }

        [HttpPost]
        public IActionResult Index(BMIResult bMIResult)
        {

            if (bMIResult.Weight == 0 & bMIResult.Height == 0)
            {
                bMIResult.Result = "";
            } else
            { 
               double result = bMIResult.Weight / (bMIResult.Height * bMIResult.Height);
                if(result <18.5)
                {
                    bMIResult.Result = "Underweight";
                } else if(result < 25)
                {
                    bMIResult.Result = "Normal";
                } else if (result < 30)
                {
                    bMIResult.Result = "Overweight";
                } else if (result < 35)
                {
                    bMIResult.Result = "Obese";
                } else
                {
                    bMIResult.Result = "Extremely Obese";
                }
            }
            return View(bMIResult);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
