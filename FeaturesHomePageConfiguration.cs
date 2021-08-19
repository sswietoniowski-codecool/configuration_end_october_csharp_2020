using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace configuration
{
    public class FeaturesHomePageConfiguration
    {
        [Required]
        public bool EnableGreeting { get; set; }
        
        public string GreetingMessage { get; set; }

        public string GreetingColor { get; set; }
    }
}
