using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba9
{
    internal class Decanat :DbContext
    {
        public DbSet<Speciality> Specialities { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Disciplines> Disciplines { get; set; }
        public DbSet<Studying> Studyings { get; set; }
        public DbSet<Teaching> Teachings { get; set; }
        public Decanat(DbContextOptions<Decanat> options) : base(options)
        {
            
        }
    }
}
