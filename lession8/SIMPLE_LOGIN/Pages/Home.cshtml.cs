using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace SIMPLE_LOGIN.Pages
{
    public class HomeModel : PageModel
    {
        private readonly ILogger _logger;

        public HomeModel(ILogger logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}