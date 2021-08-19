using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Channels;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace configuration
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddMyService(this IServiceCollection services, IConfiguration configuration)
        {
            bool myServiceEnabled = configuration.GetValue<bool>("MyService:Enabled");

            if (myServiceEnabled)
            {
                string myServiceUrl = configuration.GetValue<string>("MyService:Url");

                // we can use DI to instantiate our service here
            }
            else
            {
                // service is not enabled
            }

            return services;
        }
    }
}
