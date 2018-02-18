using NetCoreStack.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NetCoreStack101.SharedLibrary.ViewModels
{
    public class StudentViewModel: CollectionModel
    {
        [Required]
        [Display(Name = "Öğrenci Ad")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Öğrenci Soyad")]
        public string Surname { get; set; }

   
        public int Age { get; set; }

       
        public DateTime DateOfBirth { get; set; }

        [Required]
        public int ClassroomId { get; set; }

        [Required]
        [Display(Name = "Sınıf Adı")]
        public string ClassroomName { get; set; }

    }
}
