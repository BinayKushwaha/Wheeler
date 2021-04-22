using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Wheeler.Database.Context
{
    public sealed class ContextFactory:IDesignTimeDbContextFactory<WhelerDbContext>
    {
        public WhelerDbContext CreateDbContext(string[] args)
        {
            const string connectionString = "Server=BINAYKUSHWAHA\\KALE;Database=Database;Integrated Security=true;Connection Timeout=10;";
            var builder = new DbContextOptionsBuilder<WhelerDbContext>();
            builder.UseSqlServer(connectionString, options => options.MigrationsAssembly(Assembly.GetExecutingAssembly().GetName().Name));
            return new WhelerDbContext(builder.Options);
        }
    }
}
