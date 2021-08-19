using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace configuration.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly FeaturesHomePageConfiguration _featuresHomePageConfiguration;

        public bool EnableGreeting { get; set; }
        public string GreetingMessage { get; set; }
        public string GreetingColor { get; set; }
        public string SecretKey { get; set; }
        public bool HasSecretKey => !string.IsNullOrEmpty(SecretKey);

        public IndexModel(ILogger<IndexModel> logger, IOptionsSnapshot<FeaturesHomePageConfiguration> options)
        {
            _featuresHomePageConfiguration = options.Value;
            _logger = logger;
        }

        public void OnGet()
        {
            EnableGreeting = _featuresHomePageConfiguration.EnableGreeting;
            GreetingMessage = _featuresHomePageConfiguration.GreetingMessage;
            GreetingColor = _featuresHomePageConfiguration.GreetingColor;
            SecretKey = _featuresHomePageConfiguration.SecretKey;
        }
    }
}