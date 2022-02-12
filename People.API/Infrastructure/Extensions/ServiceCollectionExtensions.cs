using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace People.API.Infrastructure.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IPeopleRepository, PeopleRepository>();
            services.AddScoped<IPeopleRepository, PeopleRepository>();
            services.AddScoped<IPeopleRepository, PeopleRepository>();
            services.AddScoped<IPeopleRepository, PeopleRepository>();
            services.AddScoped<IPeopleRepository, PeopleRepository>();
            services.AddScoped<IPeopleRepository, PeopleRepository>();
            services.AddScoped<IPeopleRepository, PeopleRepository>();
            services.AddScoped<IPeopleRepository, PeopleRepository>();
            services.AddScoped<IPeopleRepository, PeopleRepository>();
            services.AddScoped<IPeopleRepository, PeopleRepository>();
            services.AddScoped<IPeopleRepository, PeopleRepository>();
            services.AddScoped<IPeopleRepository, PeopleRepository>();

            services.AddScoped<IErpIntegrationService, ErpIntegrationService>();
            services.AddScoped<IErpIntegrationService, ErpIntegrationService>();
            services.AddScoped<IErpIntegrationService, ErpIntegrationService>();
            services.AddScoped<IErpIntegrationService, ErpIntegrationService>();
            services.AddScoped<IErpIntegrationService, ErpIntegrationService>();
            services.AddScoped<IErpIntegrationService, ErpIntegrationService>();

            return services;
        }
    }
}
