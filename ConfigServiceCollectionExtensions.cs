using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RegexProject.Interface;
using RegexProject.Sevice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexProject
{
    public static class ConfigServiceCollectionExtensions
    {
        public static IServiceCollection AddConfig(this IServiceCollection services)
        {
            services.AddTransient<IReadWebpage, ReadWebpage>();
            return services;
        }
    }
}
