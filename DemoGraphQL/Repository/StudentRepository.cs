using DemoGraphQL.Context;
using DemoGraphQL.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoGraphQL.Repository
{
    public class StudentRepository: IStudentRepository
    {
        private readonly DemoAppContext _context;

        public StudentRepository(DemoAppContext context)
        {
            _context = context;
        }

        public IEnumerable<Student> GetAllStudentsPerDepartment(Guid departmentId) => _context.Students
               .Where(a => a.DepartmentId.Equals(departmentId))
               .ToList();

        public async Task<ILookup<Guid, Student>> GetStudentsByOwnerIds(IEnumerable<Guid> departmentIds)
        {
            var students = await _context.Students.Where(a => departmentIds.Contains(a.DepartmentId)).ToListAsync();
            return students.ToLookup(x => x.DepartmentId);
        }
    }

    public interface IStudentRepository
    {
        IEnumerable<Student> GetAllStudentsPerDepartment(Guid departmentId);
        Task<ILookup<Guid, Student>> GetStudentsByOwnerIds(IEnumerable<Guid> ownerIds);
    }
}
