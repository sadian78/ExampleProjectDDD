using ExampleProjectDDD.Application.DTOs.CourseManagment;
using ExampleProjectDDD.Application.Sevices;
using ExampleProjectDDD.Shared.Abstraction.Queries;

namespace ExampleProjectDDD.Application.Queries.CourseManagment.Handler
{
    public class GetCourseByIdHandler : IQueryHandler<GetCourseById, CourseDTO>
    {
        private ICourseReadModelServices _courseReadModelServices;

        public GetCourseByIdHandler(ICourseReadModelServices courseReadModelServices)
        {
            _courseReadModelServices = courseReadModelServices;
        }

        public async Task<CourseDTO> HandleAsync(GetCourseById query)
        {
            return (await _courseReadModelServices.GetCourseByIdAsync(query.Id)).ToDTO();
        }
    }
}
