using ExampleProjectDDD.Application.DTOs.CourseManagment;
using ExampleProjectDDD.Shared.Abstraction.Queries;

namespace ExampleProjectDDD.Application.Queries.CourseManagment
{
    public class GetCourseById : IQuery<CourseDTO>
    {
        public Guid Id { get; set; }
    }
}
