using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using Wheeler.Model.DbEntities;

namespace Wheeler.Database.Context
{
    public sealed class ApplcationContext:DbContext
    {
        public ApplcationContext(DbContextOptions<DbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<ApplicationUsers> ApplicationUsers { get; set; }
        public DbSet<ApplicationRoles> ApplicationRoles { get; set; }
        public DbSet<AppUsers> AppUsers { get; set; }
        public DbSet<PersonalDetail> PersonalDetails { get; set; }
    }
}
