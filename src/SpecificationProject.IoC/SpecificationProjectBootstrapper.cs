using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using SpecificationProject.Data;
using SpecificationProject.Domain;
using SpecificationProject.Domain.Repositories;

namespace SpecificationProject.IoC
{
    public class SpecificationProjectBootstrapper
    {
        public static void Register(IServiceCollection services)
        {
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<SpecificationProjectContext>();
        }
    }
}
