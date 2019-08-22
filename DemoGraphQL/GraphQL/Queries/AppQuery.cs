using DemoGraphQL.GraphQL.Types;
using DemoGraphQL.Model;
using DemoGraphQL.Repository;
using GraphQL;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoGraphQL.GraphQL.Queries
{
    public class AppQuery : ObjectGraphType
    {
        public AppQuery(IDepartmentRepository repository)
        {
            Field<ListGraphType<GraphDepartment>>(
               "departments",
               resolve: context => repository.GetAll()
            );

            Field<GraphDepartment>(
                "department",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<IdGraphType>> { Name = "departmentId" }),
                resolve: context =>
                {
                    Guid id;
                    if (!Guid.TryParse(context.GetArgument<string>("departmentId"), out id))
                    {
                        context.Errors.Add(new ExecutionError("Wrong value for guid"));
                        return null;
                    }

                    return repository.GetById(id);
                }
            );
        }
    }
}
