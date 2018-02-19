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
        [Display(Name = "Student Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "student Surname")]
        public string Surname { get; set; }

        [Required]
        [Display(Name = "E-Mail")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Age")]
        public int Age { get; set; }


        [Required]
        [Display(Name = "Student Birth Date")]
        public DateTime DateOfBirth { get; set; }

  

        //[Required]
        //public int ClassroomId { get; set; }

        //[Required]
        //[Display(Name = "Sınıf Adı")]
        //public string ClassroomName { get; set; }

    }
}
