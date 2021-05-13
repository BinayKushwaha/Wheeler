﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Wheeler.Model.DbEntities;

namespace Wheeler.Database.Configuration
{
    public sealed class AppUserConfiguration : IEntityTypeConfiguration<AppUsers>
    {
        public void Configure(EntityTypeBuilder<AppUsers> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Property(a => a.IsCompnay).IsRequired().HasDefaultValue(false);
            builder.Property(a => a.IsEmployee).IsRequired().HasDefaultValue(false);
           
            builder.Property(a => a.UserId).IsRequired();
            builder.HasOne(a => a.Users).WithOne(b => b.AppUsers).
                HasForeignKey<AppUsers>(c => c.UserId).
                HasConstraintName("FK_AspNetUsers_AppsUser");
        }
    }
}
