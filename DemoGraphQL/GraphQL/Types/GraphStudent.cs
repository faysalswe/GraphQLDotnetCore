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
    public class GraphStudent: ObjectGraphType<Student>
    {
        public GraphStudent(IStudentRepository repository, IDataLoaderContextAccessor dataLoader)
        {
            Field(x => x.Id, type: typeof(IdGraphType)).Description("Id property from the owner object.");
            Field(x => x.Name, type: typeof(IdGraphType)).Description("Name property from the owner object.");
            Field(x => x.Age, type: typeof(IdGraphType)).Description("Address property from the owner object.");
            //Field<ListGraphType<GraphCourse>>(
            //    "courses",
            //    resolve: context =>
            //    {
            //        var loader = dataLoader.Context.GetOrAddCollectionBatchLoader<Guid, Course>("GetAccountsByOwnerIds", repository.GetAccountsByOwnerIds);
            //        return loader.LoadAsync(context.Source.Id);
            //    });
        }
    }
}
