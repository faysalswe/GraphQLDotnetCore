using DemoGraphQL.Model;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoGraphQL.GraphQL.Types
{
    public class CourseEnumType : EnumerationGraphType<TypeOfCourse>
    {
        public CourseEnumType()
        {
            Name = "Type";
            Description = "Enumeration for the account type object.";
        }
    }
}
