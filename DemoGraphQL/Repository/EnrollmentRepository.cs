using DemoGraphQL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoGraphQL.Repository
{
    public class EnrollmentRepository: IEnrollmentRepository
    {
        private readonly DemoAppContext _context;

        public EnrollmentRepository(DemoAppContext context)
        {
            _context = context;
        }
    }

    public interface IEnrollmentRepository
    {
    }
}
