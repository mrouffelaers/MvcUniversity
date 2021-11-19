using System;
using System.ComponentModel.DataAnnotations;

namespace MvcUniversity.Models
{
    public class Enrollment
    {
        public int Id { get; set; }

        [DisplayFormat(NullDisplayText ="No grade")]
        public Grade? Grade { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public Student Student { get; set; }
        public Course Course {get; set;}

    }

    public enum Grade
    { 
        A, B, C, D, F
    }
}