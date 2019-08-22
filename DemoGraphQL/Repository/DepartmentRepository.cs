using DemoGraphQL.Context;
using DemoGraphQL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoGraphQL.Repository
{
    public class DepartmentRepository: IDepartmentRepository
    {
        private readonly DemoAppContext _context;

        public DepartmentRepository(DemoAppContext context)
        {
            _context = context;
        }

        public IEnumerable<Department> GetAll() => _context.Departments.ToList();

        public Department GetById(Guid id) => _context.Departments.SingleOrDefault(o => o.Id.Equals(id));
    }
    public interface IDepartmentRepository
    {
        IEnumerable<Department> GetAll();
        Department GetById(Guid id);
    }
}
