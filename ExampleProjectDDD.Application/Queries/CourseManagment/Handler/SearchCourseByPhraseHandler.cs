using ExampleProjectDDD.Application.DTOs.CourseManagment;
using ExampleProjectDDD.Application.Sevices;
using ExampleProjectDDD.Shared.Abstraction.Queries;

namespace ExampleProjectDDD.Application.Queries.CourseManagment.Handler
{
    public class SearchCourseByPhraseHandler : IQueryHandler<SearchCourseByPhrase, CouesesListDTO>
    {
        private ICourseReadModelServices _courseReadModelServices;

        public SearchCourseByPhraseHandler(ICourseReadModelServices courseReadModelServices)
        {
            _courseReadModelServices = courseReadModelServices;
        }
        public async Task<CouesesListDTO> HandleAsync(SearchCourseByPhrase query)
        {
            var courses = (await _courseReadModelServices.GetCoursesByPhraseAsync(query.Phrase))
                  .Select(c => c.ToDTO())
                  .ToList();
            return new CouesesListDTO() { Courses = courses };
        }
    }
}
