using NetCoreStack.Data.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreStack101.SharedLibrary.DbModels
{
   public class Teacher: EntityIdentitySql
    {
        public string TeacherName { get; set; }
        public string TeacherSurname { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public DateTime DateOfBirth { get; set; }
        //public int ClassroomId { get; set; }
        //public Classroom ClassOfTeacher { get; set; }

    }
}
