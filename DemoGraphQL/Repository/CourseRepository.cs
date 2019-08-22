using DemoGraphQL.Context;
using DemoGraphQL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoGraphQL.Repository
{
    public class CourseRepository: ICourseRepository
    {
        private readonly DemoAppContext _context;

        public CourseRepository(DemoAppContext context)
        {
            _context = context;
        }

        public Task<ILookup<Guid, Course>> GetAccountsByOwnerIds(IEnumerable<Guid> ownerIds)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Course> GetAllAccountsPerOwner(Guid ownerId)
        {
            throw new NotImplementedException();
        }
    }

    public interface ICourseRepository
    {
        IEnumerable<Course> GetAllAccountsPerOwner(Guid ownerId);
        Task<ILookup<Guid, Course>> GetAccountsByOwnerIds(IEnumerable<Guid> ownerIds);
    }
}
