using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Wheeler.Database.Identity;
using Wheeler.Model.DbEntities;

namespace Wheeler.Database.Configuration.Identity
{
    public sealed class RoleConfiguration : IEntityTypeConfiguration<ApplicationRoles>
    {
        public void Configure(EntityTypeBuilder<ApplicationRoles> builder)
        {
            builder.ToTable(name: "Roles");
        }
    }
}
