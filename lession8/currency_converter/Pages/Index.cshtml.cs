using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace currency_converter.Pages
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

        [BindProperty(Name = "Rate", SupportsGet = true)]
        public int Rate { get; set; }
        [BindProperty(Name = "Usd", SupportsGet = true)]
        public int Usd { get; set; }
        [BindProperty(Name = "Vnd", SupportsGet = true)]
        public int Vnd { get; set; }

          public IActionResult OnPost(int rate, int usd)
        {
            Rate = rate;
            Usd = usd;
            Vnd = rate * usd;
            return RedirectToPage("Index", new { Rate = Rate, Usd = Usd, Vnd = Vnd });
        }
    }
}
