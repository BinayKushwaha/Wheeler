using Microsoft.EntityFrameworkCore;
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
            builder.HasOne(x => x.PersonalDetail).WithOne(x => x.AppUsers)
                .HasForeignKey<PersonalDetail>(x => x.AppUserId)
                .HasConstraintName("Fk_ApplicationUser_PersonalDetail");
        }
    }
}
