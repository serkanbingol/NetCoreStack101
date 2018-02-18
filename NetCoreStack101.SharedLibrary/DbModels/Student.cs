using NetCoreStack.Data.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreStack101.SharedLibrary.DbModels
{
   public class Student: EntityIdentitySql
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int ClassroomId { get; set; }
        public Classroom ClassOfStudent { get; set; }

    }
}
