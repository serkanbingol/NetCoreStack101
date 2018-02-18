using Microsoft.EntityFrameworkCore;
using NetCoreStack.Data.Context;
using NetCoreStack.Data.Interfaces;
using NetCoreStack101.SharedLibrary.DbModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreStack101.Domain.Contexts
{
    public class NetCoreStack101Context : EfCoreContext
    {
        public NetCoreStack101Context(IDataContextConfigurationAccessor configurator,
            IDatabasePreCommitFilter filter = null) : base(configurator, filter)
        {
            if (Database.EnsureCreated())
            {
                GenerateDatabase();
            }
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Classroom> Classrooms { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (Configurator != null)
            {
                optionsBuilder.UseSqlServer(Configurator.SqlConnectionString);
            }
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        private void GenerateDatabase()
        {
            #region Students Data
            for (int i = 1; i < 16; i++)
            {
                Student student = new Student()
                {
                    Name = "StudentName_" + i.ToString(),
                    Surname = "StudentSurname" + i.ToString(),
                    Email = "studentemail_" + "_" + i.ToString() + "@email.com",
                    DateOfBirth = DateTime.Now,
                     Age=18,
                };
                Students.Add(student);
            }
            #endregion

            #region Classroom Data
            for (int i = 1; i < 6; i++)
            {
                Classroom classroom = new Classroom()
                {
                    ClassroomName = "Classroom_" + i.ToString(),
                    StudentCount=5
                };
                Classrooms.Add(classroom);
            }
            #endregion

            #region Teacher Data
            for (int i = 1; i < 6; i++)
            {
                Teacher teacher = new Teacher()
                {
                    TeacherName = "TeacherName" + i.ToString(),

                    TeacherSurname = "TeacherName" + i.ToString(),
                    Email = "teacheremail_" + "_" + i.ToString() + "@email.com",
                    DateOfBirth = DateTime.Now,
                    Age = 18,
                };
                Teachers.Add(teacher);

            }
            this.SaveChanges();
            #endregion
        }
    }
}
