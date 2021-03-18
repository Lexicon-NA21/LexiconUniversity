using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LexiconUniversity.Models.Entities
{
    public class Enrollment
    {
        //Composite key
        //modelbuilder.Entity<Enrollment>().HasKey(e => new { e.StudentId, e.CourseId });

        public int Id { get; set; }
        public int Grade { get; set; }

        public int StudentId { get; set; }
        public int CourseId { get; set; }

        //Navigation property
        public Student Student { get; set; }
        public Course Course { get; set; }

    }
}
