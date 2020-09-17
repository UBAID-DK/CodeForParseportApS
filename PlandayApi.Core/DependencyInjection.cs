using Microsoft.Extensions.DependencyInjection;
using PlandayApi.Application.Interfaces;
using PlandayApi.Instrastructor.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlandayApi.Instrastructor
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<ITaskRepository, TaskRepository>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            return services;
        }
    }
}
