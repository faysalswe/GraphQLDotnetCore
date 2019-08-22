using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoGraphQL.Model
{
    public class StudentCourse
    {
        [Key]
        public Guid Id { get; set; }
        public Guid EnrollmentId { get; set; }
        public Enrollment Enrollment { get; set; }
        public Guid CourseId { get; set; }
        public Course Course { get; set; }
    }
}
