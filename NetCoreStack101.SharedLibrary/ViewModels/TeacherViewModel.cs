using NetCoreStack.Contracts;
using NetCoreStack.Data.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NetCoreStack101.SharedLibrary.ViewModels
{
   public class TeacherViewModel: CollectionModel
    {
        [Required]
        [Display(Name = "Teacher Name")]
        public string TeacherName { get; set; }

        [Required]
        [Display(Name = "Teacher Surname")]
        public string TeacherSurname { get; set; }
        [Required]
        [Display(Name = "E-Mail")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Age")]

        public int Age { get; set; }


        [Required]
        [Display(Name = "Teacher Birth Date")]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public int ClassroomId { get; set; }

        [Required]
        [Display(Name ="Taecher Classroom Name")]
        public string ClassroomName { get; set; }

    }
}
