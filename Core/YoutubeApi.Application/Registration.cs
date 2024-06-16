using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeApi.Application
{
    public static class Registration
    {
        public static void AddApllication( this IServiceCollection services) 
        {
            var asembly = Assembly.GetExecutingAssembly();

            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(asembly));
        }
    }
}
