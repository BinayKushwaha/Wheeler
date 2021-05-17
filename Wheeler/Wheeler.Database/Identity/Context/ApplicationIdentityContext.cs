using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Wheeler.Model.DbEntities;

namespace Wheeler.Database.Identity.Context
{
    //public sealed class SecurityContext : IdentityDbContext<ApplicationUsers>
    //{
    //    public SecurityContext(DbContextOptions<SecurityContext> options)
    //       : base(options)
    //    {
    //        //Database.EnsureCreated();
    //    }

    //    protected override void OnModelCreating(ModelBuilder builder)
    //    {
    //        base.OnModelCreating(builder);

    //        //builder.ApplyConfiguration(new Wheeler.Database.Configuration.Identity.RoleConfiguration());
    //        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    //    }
    //}
}
