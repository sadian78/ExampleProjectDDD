using ExampleProjectDDD.Application.DTOs.CourseManagment;
using ExampleProjectDDD.Application.Sevices;
using ExampleProjectDDD.Shared.Abstraction.Queries;

namespace ExampleProjectDDD.Application.Queries.CourseManagment.Handler
{
    public class GetCoursesListHandler : IQueryHandler<GetCoursesList, CouesesListDTO>
    {
        private ICourseReadModelServices _courseReadModelServices;

        public GetCoursesListHandler(ICourseReadModelServices courseReadModelServices)
        {
            _courseReadModelServices = courseReadModelServices;
        }
        public async Task<CouesesListDTO> HandleAsync(GetCoursesList query)
        {
            var courses = (await _courseReadModelServices.GetCoursesAsync())
                    .Select(c => c.ToDTO())
                    .ToList();
            return new CouesesListDTO()
            {
                Courses = courses
            };
        }
    }
}
