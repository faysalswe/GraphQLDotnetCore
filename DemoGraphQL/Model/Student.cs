using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DemoGraphQL.Model
{
    public class Student
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public byte Age { get; set; }
        [ForeignKey("DepartmentId")]
        public Guid DepartmentId { get; set; }
        public Department Department { get; set; }
        public ICollection<StudentCourse> StudentCourses { get; set; }

    }
}
