using ExampleProjectDDD.Application.DTOs.CourseManagment;
using ExampleProjectDDD.Shared.Abstraction.Queries;

namespace ExampleProjectDDD.Application.Queries.CourseManagment.Handler
{
    public class SearchCourseByPhraseHandler : IQueryHandler<SearchCourseByPhrase, CouesesListDTO>
    {
        public Task<CouesesListDTO> HandleAsync(SearchCourseByPhrase query)
        {
            throw new NotImplementedException();
        }
    }
}
