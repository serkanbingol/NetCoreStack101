using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NetCoreStack101.SharedLibrary.DbModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreStack101.Domain.Mappings
{
    public class ClassroomMap : IEntityTypeConfiguration<Classroom>
    {
        public void Configure(EntityTypeBuilder<Classroom> builder)
        {
            builder.Property(x => x.Id).IsRequired();
      
        }
    }
}
