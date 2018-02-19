using NetCoreStack.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NetCoreStack101.SharedLibrary.ViewModels
{
   public  class ClassroomViewModel: CollectionModel
    {
        [Required]
        [Display(Name = "Classroom Name")]
        public string ClassroomName { get; set; }

        [Required]
        [Display(Name = "Classroom Student Count")]
        public int StudentCount { get; set; }

        //[Required]
        //public int TeacherId { get; set; }

        //[Required]

        //[Display(Name = "Classroom Teacher Fullname")]
        //public string TeacherName { get; set; }

    }
}
