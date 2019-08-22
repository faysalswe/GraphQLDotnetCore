using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoGraphQL.Model
{
    public class Enrollment
    {
        [Key]
        public Guid Id { get; set; }
        public Semester Semester { get; set; }
        public short Year { get; set; }
        public Guid StudentId { get; set; }
        public Student Student { get; set; }
    }
    public enum Semester
    {
        Summer,
        Fall,
        Spring
    }
}
