using University.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace University.Data
{
    public static class DbInitializer
    {
        public static void Initialize(SchoolContext context)
        {
            // Look for any students.
            if (context.Students.Any())
            {
                return;   // DB has been seeded
            }

            var samuel = new Student
            {
                FirstMidName = "Samuel",
                LastName = "Conde",
                EnrollmentDate = DateTime.Parse("2016-09-01")
            };

            var roger = new Student
            {
                FirstMidName = "Roger",
                LastName = "Santos",
                EnrollmentDate = DateTime.Parse("2018-09-01")
            };

            var hector = new Student
            {
                FirstMidName = "Héctor",
                LastName = "Fuentes",
                EnrollmentDate = DateTime.Parse("2019-09-01")
            };

            var naomi = new Student
            {
                FirstMidName = "Naomi",
                LastName = "Bautista",
                EnrollmentDate = DateTime.Parse("2018-09-01")
            };

            var diego = new Student
            {
                FirstMidName = "Diego",
                LastName = "Gómez",
                EnrollmentDate = DateTime.Parse("2018-09-01")
            };

            var max = new Student
            {
                FirstMidName = "Max",
                LastName = "Camacho",
                EnrollmentDate = DateTime.Parse("2017-09-01")
            };

            var emilio = new Student
            {
                FirstMidName = "Emilio",
                LastName = "Mamado",
                EnrollmentDate = DateTime.Parse("2019-09-01")
            };

            var eduardo = new Student
            {
                FirstMidName = "Eduardo",
                LastName = "Escamilla",
                EnrollmentDate = DateTime.Parse("2011-09-01")
            };

            var students = new Student[]
            {
                samuel,
                roger,
                hector,
                naomi,
                diego,
                max,
                emilio,
                eduardo
            };

            context.AddRange(students);

            var luna = new Instructor
            {
                FirstMidName = "Luis",
                LastName = "Luna",
                HireDate = DateTime.Parse("1995-03-11")
            };

            var cuellar = new Instructor
            {
                FirstMidName = "Luis",
                LastName = "Cuellar",
                HireDate = DateTime.Parse("2002-07-06")
            };

            var jose = new Instructor
            {
                FirstMidName = "José",
                LastName = "Delgado",
                HireDate = DateTime.Parse("1998-07-01")
            };

            var miguel = new Instructor
            {
                FirstMidName = "Miguel",
                LastName = "Salvador",
                HireDate = DateTime.Parse("2001-01-15")
            };

            var bibiana = new Instructor
            {
                FirstMidName = "Bibiana",
                LastName = "Bárcenas",
                HireDate = DateTime.Parse("2004-02-12")
            };

            var instructors = new Instructor[]
            {
                luna,
                cuellar,
                jose,
                miguel,
                bibiana
            };

            context.AddRange(instructors);

            var officeAssignments = new OfficeAssignment[]
            {
                new OfficeAssignment {
                    Instructor = luna,
                    Location = "Smith 17" },
                new OfficeAssignment {
                    Instructor = bibiana,
                    Location = "Gowan 27" },
                new OfficeAssignment {
                    Instructor = miguel,
                    Location = "Thompson 304" }
            };

            context.AddRange(officeAssignments);

            var ingles = new Department
            {
                Name = "Inglés",
                Budget = 350000,
                StartDate = DateTime.Parse("2007-09-01"),
                Administrator = miguel
            };

            var matematicas = new Department
            {
                Name = "Matemáticas",
                Budget = 100000,
                StartDate = DateTime.Parse("2007-09-01"),
                Administrator = jose
            };

            var diseño = new Department
            {
                Name = "Diseño",
                Budget = 350000,
                StartDate = DateTime.Parse("2007-09-01"),
                Administrator = luna
            };

            var programacion = new Department
            {
                Name = "programacion",
                Budget = 100000,
                StartDate = DateTime.Parse("2007-09-01"),
                Administrator = bibiana
            };

            var departments = new Department[]
            {
                ingles,
                matematicas,
                diseño,
                programacion
            };

            context.AddRange(departments);

            var ingles2 = new Course
            {
                CourseID = 1050,
                Title = "Inglés II",
                Credits = 3,
                Department = ingles,
                Instructors = new List<Instructor> { bibiana, miguel }
            };

            var asp = new Course
            {
                CourseID = 4022,
                Title = "ASP.NET",
                Credits = 5,
                Department = programacion,
                Instructors = new List<Instructor> { bibiana }
            };

            var diseñoWeb = new Course
            {
                CourseID = 4041,
                Title = "Diseño Web",
                Credits = 3,
                Department = diseño,
                Instructors = new List<Instructor> { luna }
            };

            var calculo = new Course
            {
                CourseID = 1045,
                Title = "Calculo",
                Credits = 4,
                Department = matematicas,
                Instructors = new List<Instructor> { jose }
            };

            var trigonometria = new Course
            {
                CourseID = 3141,
                Title = "Trigonometría",
                Credits = 4,
                Department = matematicas,
                Instructors = new List<Instructor> { jose }
            };

            var baseDatos = new Course
            {
                CourseID = 2021,
                Title = "Base de Datos",
                Credits = 3,
                Department = programacion,
                Instructors = new List<Instructor> { cuellar }
            };

            var fundamentos = new Course
            {
                CourseID = 2042,
                Title = "Fundamentos",
                Credits = 4,
                Department = programacion,
                Instructors = new List<Instructor> { cuellar }
            };

            var courses = new Course[]
            {
                ingles2,
                asp,
                diseñoWeb,
                calculo,
                trigonometria,
                baseDatos,
                fundamentos
            };

            context.AddRange(courses);

            var enrollments = new Enrollment[]
            {
                new Enrollment {
                    Student = hector,
                    Course = ingles2,
                    Grade = Grade.A
                },
                new Enrollment {
                    Student = hector,
                    Course = asp,
                    Grade = Grade.C
                },
                new Enrollment {
                    Student = hector,
                    Course = diseñoWeb,
                    Grade = Grade.B
                },
                new Enrollment {
                    Student = naomi,
                    Course = calculo,
                    Grade = Grade.B
                },
                new Enrollment {
                    Student = naomi,
                    Course = trigonometria,
                    Grade = Grade.B
                },
                new Enrollment {
                    Student = naomi,
                    Course = baseDatos,
                    Grade = Grade.B
                },
                new Enrollment {
                    Student = samuel,
                    Course = asp
                },
                new Enrollment {
                    Student = samuel,
                    Course = asp,
                    Grade = Grade.B
                },
                new Enrollment {
                    Student = roger,
                    Course = asp,
                    Grade = Grade.B
                },
                new Enrollment {
                    Student = diego,
                    Course = baseDatos,
                    Grade = Grade.B
                },
                new Enrollment {
                    Student = max,
                    Course = fundamentos,
                    Grade = Grade.B
                }
            };

            context.AddRange(enrollments);
            context.SaveChanges();
        }
    }
}