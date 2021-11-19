using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace MvcUniversity.Models
{
    public class Course
    {
        [Display(Name = "Number")]
        public int Id { get; set; }
        [StringLength(50, MinimumLength = 4),Required]
        public string Title { get; set; }
        public int Credits { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}