using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LexiconUniversity.Models.Entities;

namespace LexiconUniversity.Data
{
    public class LexiconUniversityContext : DbContext
    {
        public DbSet<Student> Student { get; set; }
        public LexiconUniversityContext (DbContextOptions<LexiconUniversityContext> options)
            : base(options)
        {
        }


        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder);

        //    optionsBuilder.UseSqlServer()
        //                   .LogTo()
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // modelBuilder.Entity<Enrollment>().HasKey(e => new { e.StudentId, e.CourseId });

            modelBuilder.Entity<Student>()
                 .HasMany(s => s.Courses)
                 .WithMany(c => c.Students)
                 .UsingEntity<Enrollment>(
                     e => e.HasOne(e => e.Course).WithMany(c => c.Enrollments),
                     e => e.HasOne(e => e.Student).WithMany(s => s.Enrollments));
        }

    }
}
