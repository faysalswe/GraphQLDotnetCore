using DemoGraphQL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoGraphQL.Repository
{
    public class StudentCourseRepository: IStudentCourseRepository
    {
        private readonly DemoAppContext _context;

        public StudentCourseRepository(DemoAppContext context)
        {
            _context = context;
        }
    }

    public interface IStudentCourseRepository
    {

    }
}
