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

    }
}
