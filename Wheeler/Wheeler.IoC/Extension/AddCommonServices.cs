using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using Wheeler.Application;
using Wheeler.Domain;

namespace Wheeler.IoC
{
    public static class AddCommonServices
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IUserDomain, UserDomain>();
            services.AddTransient<IUserApplication, UserApplication>();
        }
    }
}
