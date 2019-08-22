using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DemoGraphQL.Model
{
    public class Course
    {
        [Key]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Type is required")]
        public TypeOfCourse Type { get; set; }
        public string Description { get; set; }
        public ICollection<StudentCourse> StudentCourses { get; set; }
    }

    public enum TypeOfCourse
    {
        Industryrial,
        Theory,
        Lab
    }
}
