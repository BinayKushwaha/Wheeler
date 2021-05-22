﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Wheeler.Database.Context;
using Wheeler.IoC.Helper;

namespace Wheeler.IoC
{
    public static class IServiceCollectionExtension
    {
        public static void AddCustomServices(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration["ConnectionStrings:ConnectionDbString"];

            services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(connectionString));

            AddIdentityServices.ConfigureService(services,configuration);
            AddRepositoryServices.ConfiguerServices(services);
            AddCommonServices.ConfigureServices(services);

        }
    }
}
