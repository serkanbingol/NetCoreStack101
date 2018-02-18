using NetCoreStack.Data.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreStack101.SharedLibrary.DbModels
{
   public  class Classroom: EntityIdentitySql
    {
        public string ClassroomName { get; set; }
        public int StudentCount { get; set; }
        public int TeacherId { get; set; }
        public Teacher TeacherOfClassroom { get; set; }
    }
}
