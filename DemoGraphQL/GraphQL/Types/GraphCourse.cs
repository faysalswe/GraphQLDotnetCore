using DemoGraphQL.Model;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoGraphQL.GraphQL.Types
{
    public class GraphCourse : ObjectGraphType<Course>
    {
        public GraphCourse()
        {
            Field(x => x.Id, type: typeof(IdGraphType)).Description("Id property from the account object.");
            Field(x => x.Description).Description("Description property from the account object.");
            Field<CourseEnumType>("Type", "Enumeration for the account type object.");
        }
    }
}
