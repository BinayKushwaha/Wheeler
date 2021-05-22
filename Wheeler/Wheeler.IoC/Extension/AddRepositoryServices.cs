using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Wheeler.Database.Repository;

namespace Wheeler.IoC.Helper
{
    public static class AddRepositoryServices
    {
        public static void ConfiguerServices(IServiceCollection services)
        {
            services.AddScoped(typeof(IRepositoryService<,>), typeof(RepositoryService<,>));
            services.AddTransient<IUnitOfWork, UnitOfWork>();
        }
    }
}
