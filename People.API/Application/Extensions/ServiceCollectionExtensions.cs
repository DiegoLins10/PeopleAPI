using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace People.API.Application.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IPeopleService, PeopleService>();
            services.AddScoped<IPeopleService, PeopleService>();
            services.AddScoped<IPeopleService, PeopleService>();
            services.AddScoped<IPeopleService, PeopleService>();
            services.AddScoped<IPeopleService, PeopleService>();
            services.AddScoped<IPeopleService, PeopleService>();
            services.AddScoped<IPeopleService, PeopleService>();
            services.AddScoped<IPeopleService, PeopleService>();
            services.AddScoped<IPeopleService, PeopleService>();
            services.AddScoped<IPeopleService, PeopleService>();
            services.AddScoped<IPeopleService, PeopleService>();

            return services;
        }
    }
}
