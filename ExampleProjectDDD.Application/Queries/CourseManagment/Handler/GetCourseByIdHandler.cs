using ExampleProjectDDD.Application.DTOs.CourseManagment;
using ExampleProjectDDD.Shared.Abstraction.Queries;

namespace ExampleProjectDDD.Application.Queries.CourseManagment.Handler
{
    public class GetCourseByIdHandler : IQueryHandler<GetCourseById, CourseDTO>
    {
        public Task<CourseDTO> HandleAsync(GetCourseById query)
        {
            throw new NotImplementedException();
        }
    }
}
