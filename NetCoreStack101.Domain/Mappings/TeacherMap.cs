using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NetCoreStack101.SharedLibrary.DbModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreStack101.Domain.Mappings
{
    public class TeacherMap : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.Email).IsRequired();
            //builder.HasOne(x => x.ClassOfTeacher).WithOne(x => x.TeacherOfClassroom).HasForeignKey<Classroom>(x => x.TeacherId);
        }
    }
}
