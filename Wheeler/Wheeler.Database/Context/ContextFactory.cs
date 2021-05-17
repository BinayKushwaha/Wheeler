using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Wheeler.Database.Identity.Context;

namespace Wheeler.Database.Context
{
    //public sealed class ContextFactory : IDesignTimeDbContextFactory<SecurityContext>
    //{
    //    public SecurityContext CreateDbContext(string[] args)
    //    {
    //        const string connectionString = "Server=BINAYKUSHWAHA\\KALE;Database=Wheeler;UID=sa;PWD=kush;";
    //        var builder = new DbContextOptionsBuilder<SecurityContext>();
    //        builder.UseSqlServer(connectionString, options => options.MigrationsAssembly(Assembly.GetExecutingAssembly().GetName().Name));
    //        return new SecurityContext(builder.Options);
    //    }
    //}

   
}
