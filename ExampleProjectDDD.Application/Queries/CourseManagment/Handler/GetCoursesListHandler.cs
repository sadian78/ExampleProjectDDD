using ExampleProjectDDD.Application.DTOs.CourseManagment;
using ExampleProjectDDD.Shared.Abstraction.Queries;

namespace ExampleProjectDDD.Application.Queries.CourseManagment.Handler
{
    public class GetCoursesListHandler : IQueryHandler<GetCoursesList, CouesesListDTO>
    {
        public Task<CouesesListDTO> HandleAsync(GetCoursesList query)
        {
            throw new NotImplementedException();
        }
    }
}
