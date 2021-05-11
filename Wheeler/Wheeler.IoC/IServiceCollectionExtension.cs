using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Wheeler.Database.Context;
using Wheeler.Database.Identity;
using Wheeler.Database.Identity.Context;
using Wheeler.Model.DbEntities;

namespace Wheeler.IoC
{
    public static class IServiceCollectionExtension
    {
        public static void AddCustomServices(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration["ConnectionStrings:ConnectionDbString"];
            
            services.AddDbContext<SecurityContext>(options => options.UseSqlServer(connectionString));
            services.AddDbContextPool<ApplcationContext>(options => options.UseSqlServer(connectionString));

            services.AddIdentityCore<ApplicationUsers>(options => options.SignIn.RequireConfirmedAccount = true).AddRoles<ApplicationRoles>()
            .AddEntityFrameworkStores<SecurityContext>();
        }
    }
}
