using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace simple_dictionary.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }


        public void OnPost(string word)
        {
            Dictionary<string, string> libs = new Dictionary<string, string>();
            libs.Add("hello", "Xin Chào");
            libs.Add("book", "quyển sách");
            libs.Add("school", "trường học");
            libs.Add("employee", "nhân viên");

            bool isMatched = false;
            foreach (var item in libs)
            {
                if (item.Key == word)
                {
                    isMatched = true;
                    ViewData["result"] = "English: " + item.Key +"_________"+ "Việt Nam: " + item.Value;
                }
            }
            if (!isMatched)
            {
                ViewData["result"] = "Find not found!";
            }
        }
    }
}
