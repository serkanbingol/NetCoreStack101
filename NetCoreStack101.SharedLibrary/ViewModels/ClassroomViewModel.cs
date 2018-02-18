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
        [Display(Name = "Sınıf Adı")]
        public string ClassroomName { get; set; }

        [Required]
        [Display(Name = "Öğrenci Sayısı")]
        public int StudentCount { get; set; }

        [Required]
        public int TeacherId { get; set; }

        [Required]

        [Display(Name = "Öğretmen Tam Ad")]
        public string TeacherName { get; set; }

    }
}
