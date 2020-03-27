using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationTest.Models
{
    public class Student
    {
        [Key]
       
        public int ID { get; set; }
        [Required( ErrorMessage ="The name is required")]
        [MaxLength(10, ErrorMessage ="The maximun lenght of the name is 10")]
        [Display(Name = "Last Name")]
        public string LName { get; set; }
        [Required(ErrorMessage ="the First name should not be null")]
        [Display(Name = "First Name")]
        public string FName { get; set; }
       [Display(Name ="Age of the Student")]
       
        public int Age { get; set; }
    }
}
