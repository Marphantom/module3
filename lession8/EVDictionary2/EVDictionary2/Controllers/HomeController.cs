using EVDictionary2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EVDictionary2.Controllers
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
            return View(new Dictionary());
        }
        [HttpPost]
        public IActionResult Index(Dictionary model)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("hello", "Xin Chào");
            dictionary.Add("book", "quyển sách");
            dictionary.Add("school", "trường học");
            dictionary.Add("employee", "nhân viên");
            if(ModelState.IsValid)
            {
              
                foreach(var key in dictionary.Keys)
                {
                    if(key.ToLower() == model.KeyWord.ToLower())
                    {
                        var result = "";
                        dictionary.TryGetValue(key, out result);
                        model.Result = result;
                    }
                }
            }
            return View(model);
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
