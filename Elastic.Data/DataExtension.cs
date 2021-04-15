using System;
using System.Collections.Generic;
using System.Text;
using Elastic.Data.Definitions;
using Elastic.Data.Implementations;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
namespace Elastic.Data
{
    public static class DataExtension
    {
        public static IServiceCollection RegisterData(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IElasticsearchRepository, ElasticsearchRepository>();
            services.AddTransient<IHttpRequestContext, HttpRequestContext>();
            return services;
        }
    }
}
