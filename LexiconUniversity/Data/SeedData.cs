using Bogus;
using LexiconUniversity.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LexiconUniversity.Data
{
    public static class SeedData
    {
        private static Faker fake;

        public static async Task InitAsync(IServiceProvider services)
        {
            using (var db = services.GetRequiredService<LexiconUniversityContext>())
            {
                fake = new Faker("sv");
                // db.Database.EnsureDeleted();
                // db.Database.Migrate();

                if (db.Student.Any())
                {
                    return;
                }
                List<Student> students = GetStudents();
                await db.AddRangeAsync(students);

                var courses = new List<Course>();

                for (int i = 0; i < 20; i++)
                {
                    var course = new Course
                    {
                        Title = fake.Company.CatchPhrase()
                    };

                    courses.Add(course);
                }

                await db.AddRangeAsync(courses);


                var enrollments = new List<Enrollment>();

                foreach (var student in students)
                {
                    foreach (var course in courses)
                    {
                        if (fake.Random.Int(0, 5) == 0)
                        {
                            var enrollment = new Enrollment
                            {
                                Course = course,
                                Student = student,
                                Grade = fake.Random.Int(1, 5)
                            };
                            enrollments.Add(enrollment);
                        }
                    }
                }

                 await db.AddRangeAsync(enrollments);
                 await db.SaveChangesAsync();
            }

        }

        private static List<Student> GetStudents()
        {
            var students = new List<Student>();

            for (int i = 0; i < 200; i++)
            {
                var fName = fake.Name.FirstName();
                var lName = fake.Name.LastName();

                var student = new Student
                {
                    FirstName = fName,
                    LastName = lName,
                    Email = fake.Internet.Email($"{fName} {lName}"),
                    Avatar = fake.Internet.Avatar(),
                    Adress = new Adress
                    {
                        City = fake.Address.City(),
                        Street = fake.Address.StreetAddress(),
                        ZipCode = fake.Address.ZipCode()
                    }

                };

                students.Add(student);
            }

            return students;
        }
    }
}