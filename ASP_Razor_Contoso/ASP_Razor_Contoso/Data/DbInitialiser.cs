using ContosoUniversity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Razor_Contoso.Data
{
    public class DbInitialiser
    {
        public static void Initialize(ApplicationDbContext context)
        {
            // Look for any students.
            if (context.Students.Any())
            {
                return;   // DB has been seeded
            }

            var students = new Student[]
            {
                new Student{FirstName="Mauro",LastName="Nunes",EnrollmentDate=DateTime.Parse("2019-09-01")},
                new Student{FirstName="Alice",LastName="Deodato",EnrollmentDate=DateTime.Parse("2017-09-01")},
                new Student{FirstName="Iris",LastName="Rangel",EnrollmentDate=DateTime.Parse("2018-09-01")},
                new Student{FirstName="Andre",LastName="Santos",EnrollmentDate=DateTime.Parse("2017-09-01")},
                new Student{FirstName="Diogo",LastName="Belchior",EnrollmentDate=DateTime.Parse("2017-09-01")},
                new Student{FirstName="Sergio",LastName="Soares",EnrollmentDate=DateTime.Parse("2016-09-01")},
                new Student{FirstName="Hernani",LastName="Maquina",EnrollmentDate=DateTime.Parse("2018-09-01")},
                new Student{FirstName="Paulo",LastName="Mestre",EnrollmentDate=DateTime.Parse("2019-09-01")}
            };

            context.Students.AddRange(students);
            context.SaveChanges();

            var courses = new Course[]
            {
                new Course{CourseID=1050,Title="Computing",Credits=3},
                new Course{CourseID=4022,Title="Web Development",Credits=3},
                new Course{CourseID=4041,Title="Software Engineering",Credits=3},
                new Course{CourseID=1045,Title="Data Science",Credits=4},
                new Course{CourseID=3141,Title="Events Management",Credits=4},
                new Course{CourseID=2021,Title="Film and TV Production",Credits=3},
                new Course{CourseID=2042,Title="Performing Arts",Credits=4}
            };

            context.Courses.AddRange(courses);
            context.SaveChanges();

            var enrollments = new Enrollment[]
            {
                new Enrollment{StudentID=1,CourseID=1050,Grade=Grades.A},
                new Enrollment{StudentID=1,CourseID=4022,Grade=Grades.C},
                new Enrollment{StudentID=1,CourseID=4041,Grade=Grades.B},
                new Enrollment{StudentID=2,CourseID=1045,Grade=Grades.B},
                new Enrollment{StudentID=2,CourseID=3141,Grade=Grades.F},
                new Enrollment{StudentID=2,CourseID=2021,Grade=Grades.F},
                new Enrollment{StudentID=3,CourseID=1050},
                new Enrollment{StudentID=4,CourseID=1050},
                new Enrollment{StudentID=4,CourseID=4022,Grade=Grades.F},
                new Enrollment{StudentID=5,CourseID=4041,Grade=Grades.C},
                new Enrollment{StudentID=6,CourseID=1045},
                new Enrollment{StudentID=7,CourseID=3141,Grade=Grades.A},
            };

            context.Enrollments.AddRange(enrollments);
            context.SaveChanges();
        }
    }
}
