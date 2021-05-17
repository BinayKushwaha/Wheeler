using Microsoft.EntityFrameworkCore;
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

            IdentityHelper.ConfigureService(services);
            CommonServicesHelper.ConfigureServices(services);

            RepositoryHelper.ConfiguerServices(services);

        }
    }
}
