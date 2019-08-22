using DemoGraphQL.Model;
using DemoGraphQL.Repository;
using GraphQL.DataLoader;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoGraphQL.GraphQL.Types
{
    public class GraphDepartment : ObjectGraphType<Department>
    {
        public GraphDepartment(IStudentRepository repository, IDataLoaderContextAccessor dataLoader)
        {
            Field(x => x.Id, type: typeof(IdGraphType)).Description("Id property from the owner object.");
            Field(x => x.Name, type: typeof(IdGraphType)).Description("Name property from the owner object.");
            Field(x => x.Description, type: typeof(IdGraphType)).Description("Address property from the owner object.");
            Field<ListGraphType<GraphStudent>>(
            "students",
            resolve: context =>
            {
                var loader = dataLoader.Context.GetOrAddCollectionBatchLoader<Guid, Student>("GetAccountsByOwnerIds", repository.GetStudentsByOwnerIds);
                return loader.LoadAsync(context.Source.Id);
            });
        }
    }
}
