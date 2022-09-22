using WebApplicationCore1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WebApplicationCore1.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Student> Student { get; set; }
        public DbSet<Course> Course { get; set; }

        protected override void OnModelCreating(ModelBuilder ModelBuilder)
        {
            ModelBuilder.Entity<Student>().ToTable("Student_Table");
            ModelBuilder.Entity<Course>().ToTable("Course_Table");
            ModelBuilder.Entity<StudentCourse>().ToTable("StudentCourse_Table");

        }

    }
}
