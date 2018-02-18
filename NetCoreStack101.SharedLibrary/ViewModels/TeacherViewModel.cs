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
        [Display(Name = "Öğretmen Ad")]
        public string TeacherName { get; set; }

        [Required]
        [Display(Name = "Öğretmen Soyad")]
        public string TeacherSurname { get; set; }

        public int Age { get; set; }

        public DateTime DateOfBirth { get; set; }

        [Required]
        public int ClassroomId { get; set; }

        [Required]
        [Display(Name ="Sınıf Adı")]
        public string ClassroomName { get; set; }

    }
}
