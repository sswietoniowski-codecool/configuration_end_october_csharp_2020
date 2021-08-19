using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace configuration.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private IConfiguration _configuration;

        public bool EnableGreeting { get; set; }
        public string GreetingMessage { get; set; }
        public string GreetingColor { get; set; }

        public IndexModel(ILogger<IndexModel> logger, IConfiguration configuration)
        {
            _configuration = configuration;
            _logger = logger;
        }

        public void OnGet()
        {
            var homePageSection = _configuration.GetSection("Features:HomePage");

            EnableGreeting = homePageSection.GetValue<bool>("EnableGreeting");
            GreetingMessage = homePageSection.GetValue<string>("GreetingMessage");
            GreetingColor = homePageSection.GetValue<string>("GreetingColor");
        }
    }
}