using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcUniversity.Models;

namespace MvcUniversity.Data
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcUniversityContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcUniversityContext>>()))
            {
                // Look for any students
                if (context.Students.Any())
                {
                    return;   // DB has been seeded
                }

                var students = new Student[]
                {
                    new Student{FirstName="Carson",LastName="Alexander",EnrollmentDate=DateTime.Parse("2019-09-01")},
                    new Student{FirstName="Meredith",LastName="Alonso",EnrollmentDate=DateTime.Parse("2017-09-01")},
                    new Student{FirstName="Arturo",LastName="Anand",EnrollmentDate=DateTime.Parse("2018-09-01")},
                    new Student{FirstName="Gytis",LastName="Barzdukas",EnrollmentDate=DateTime.Parse("2017-09-01")},
                    new Student{FirstName="Yan",LastName="Li",EnrollmentDate=DateTime.Parse("2017-09-01")},
                    new Student{FirstName="Peggy",LastName="Justice",EnrollmentDate=DateTime.Parse("2016-09-01")},
                    new Student{FirstName="Laura",LastName="Norman",EnrollmentDate=DateTime.Parse("2018-09-01")},
                    new Student{FirstName="Nino",LastName="Olivetto",EnrollmentDate=DateTime.Parse("2019-09-01")}
                };
                context.Students.AddRange(students);

                var courses = new Course[]
                {
                    new Course{Id=1050,Title="Chemistry",Credits=3},
                    new Course{Id=4022,Title="Microeconomics",Credits=3},
                    new Course{Id=4041,Title="Macroeconomics",Credits=3},
                    new Course{Id=1045,Title="Calculus",Credits=4},
                    new Course{Id=3141,Title="Trigonometry",Credits=4},
                    new Course{Id=2021,Title="Composition",Credits=3},
                    new Course{Id=2042,Title="Literature",Credits=4}
                };
                context.Courses.AddRange(courses);

                var enrollments = new Enrollment[]
                {
                    new Enrollment{StudentId=1,CourseId=1050,Grade=Grade.A},
                    new Enrollment{StudentId=1,CourseId=4022,Grade=Grade.C},
                    new Enrollment{StudentId=1,CourseId=4041,Grade=Grade.B},
                    new Enrollment{StudentId=2,CourseId=1045,Grade=Grade.B},
                    new Enrollment{StudentId=2,CourseId=3141,Grade=Grade.F},
                    new Enrollment{StudentId=2,CourseId=2021,Grade=Grade.F},
                    new Enrollment{StudentId=3,CourseId=1050},
                    new Enrollment{StudentId=4,CourseId=1050},
                    new Enrollment{StudentId=4,CourseId=4022,Grade=Grade.F},
                    new Enrollment{StudentId=5,CourseId=4041,Grade=Grade.C},
                    new Enrollment{StudentId=6,CourseId=1045},
                    new Enrollment{StudentId=7,CourseId=3141,Grade=Grade.A},
                };
                context.Enrollments.AddRange(enrollments);

                context.SaveChanges();
            }
        }
    }
}