using DemoGraphQL.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoGraphQL.Context
{
    public class DemoAppContext : DbContext
    {
        public DemoAppContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //var ids = new Guid[] { Guid.NewGuid(), Guid.NewGuid() };

            //modelBuilder.ApplyConfiguration(new OwnerContextConfiguration(ids));
            //modelBuilder.ApplyConfiguration(new AccountContextConfiguration(ids));
        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }
    }
}
