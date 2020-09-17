using Microsoft.Extensions.DependencyInjection;
using Planday.Application.Interfaces;
using PlandayApi.Application.Interfaces;
using PlandayApi.Infrastructure.Repositories;

namespace PlandayApi.Infrastructure
    {
    public static class DependencyInjection
        {
        /// <summary>
        /// this setting has done for IMediator pattern implementation which will we implement latter / in future
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
            {
            services.AddTransient<ITaskRepository, TaskRepository>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            return services;
            }
        }
    }
