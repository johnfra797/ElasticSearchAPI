using Elastic.ApplicationServices.Definitions.Commands;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Elastic.Data;
using Elastic.ApplicationServices.Definitions.Querys;

namespace Elastic.ApplicationServices
{
    public static class ApplicationServicesExtension
    {
        public static IServiceCollection RegisterApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IElasticsearchCommands, ElasticsearchCommands>();
            services.AddTransient<IElasticsearchQuerys, ElasticsearchQuerys>();
            services.RegisterData(configuration);
            return services;
        }
    }
}
