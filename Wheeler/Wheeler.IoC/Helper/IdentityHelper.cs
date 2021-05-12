﻿using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Wheeler.Database.Identity.Context;
using Wheeler.Model.DbEntities;

namespace Wheeler.IoC.Helper
{
    public static class IdentityHelper
    {
        public static void ConfigureService(this IServiceCollection services)
        {
            services.AddIdentityCore<ApplicationUsers>(options => options.SignIn.RequireConfirmedAccount = true).AddRoles<ApplicationRoles>()
            .AddEntityFrameworkStores<SecurityContext>();

            services.Configure<IdentityOptions>(opt =>
            {
                // password settings
                opt.Password.RequireDigit = true;
                opt.Password.RequiredLength = 6;
                opt.Password.RequireNonAlphanumeric = true;
                opt.Password.RequireUppercase = true;
                opt.Password.RequireLowercase = true;
            });
        }
    }
}
