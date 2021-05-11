using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Wheeler.Model.DbEntities;

namespace Wheeler.Database.Configuration
{
    public class PersonalDetailConfiguration : IEntityTypeConfiguration<PersonalDetail>
    {
        public void Configure(EntityTypeBuilder<PersonalDetail> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Property(x => x.FirstName).IsRequired().HasMaxLength(200);
            builder.Property(x => x.LastName).IsRequired().HasMaxLength(250);
            builder.Property(x => x.MiddleName).HasMaxLength(200);
        }
    }
}
