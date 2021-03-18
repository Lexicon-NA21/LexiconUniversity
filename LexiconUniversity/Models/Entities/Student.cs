using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LexiconUniversity.Models.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string Avatar { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string FullName => $"{FirstName} {LastName}";

        //Navigation Property
        public ICollection<Enrollment> Enrollments { get; set; }



       //Många till många
       // public ICollection<Course> Courses { get; set; }

    }
}
