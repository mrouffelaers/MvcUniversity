using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace MvcUniversity.Models
{
    public class Student
    {
        public int Id { get; set; }
        
        [Display(Name = "Last Name"), Required]
        public string LastName { get; set; }

        [Display(Name = "First Name"), Required]
        public string FirstName { get; set; }

        [Display(Name ="Enrollment Date"), DataType(DataType.Date)]
        public DateTime EnrollmentDate { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}